using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using Interfaces;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;

namespace Networking
{
    public class SocketServer : ISocketServer
    {
        private TcpListener listener;
        private bool enEjecucion;

        public void Escuchar(int puerto, IMessageProcessor procesador)
        {
            listener = new TcpListener(IPAddress.Any, puerto);
            listener.Start();
            Console.WriteLine($"Servidor escuchando en el puerto {puerto}");
            enEjecucion = true;

            while (enEjecucion)
            {
                TcpClient cliente = listener.AcceptTcpClient();
                Console.WriteLine("Cliente conectado");
                using NetworkStream stream = cliente.GetStream();

                byte[] bufferLongitud = new byte[4];
                int bytesLeidos = stream.Read(bufferLongitud, 0, 4);
                if (bytesLeidos != 4)
                {
                    throw new InvalidOperationException("No se pudo leer la longituid del mensaje");
                }
                int longitudMensaje = BitConverter.ToInt32(bufferLongitud, 0);

                byte[] bufferMensaje = new byte[longitudMensaje];
                int totalLeido = 0;

                while (totalLeido < longitudMensaje)
                {
                    int leidos = stream.Read(bufferMensaje, totalLeido, longitudMensaje - totalLeido);
                    if (leidos == 0) break;
                    totalLeido += leidos;
                }
                string json = Encoding.UTF8.GetString(bufferMensaje, 0, totalLeido);
                Mensaje mensaje = JsonSerializer.Deserialize<Mensaje>(json);

                procesador.ProcesarMensaje(mensaje);

                //stream.Close();
                //cliente.Close();
            }
        }

        public void Detener()
        {
            enEjecucion = false;
            listener?.Stop();
        }
    }
}
