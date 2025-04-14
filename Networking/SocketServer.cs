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
    public class SocketServer
    {
        private TcpListener listener;
        private bool enEjecucion;

        public void Escuchar(int puerto, IMessageProcessor procesador)
        {
            listener = new TcpListener(IPAddress.Any, puerto);
            listener.Start();
            enEjecucion = true;

            while (enEjecucion)
            {
                TcpClient cliente = listener.AcceptTcpClient();
                NetworkStream stream = cliente.GetStream();
                byte[] buffer = new byte[1024];
                int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                string json = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);
                Mensaje mensaje = JsonSerializer.Deserialize<Mensaje>(json);

                procesador.ProcesarMensaje(mensaje);

                stream.Close();
                cliente.Close();
            }
        }

        public void Detener()
        {
            enEjecucion = false;
            listener?.Stop();
        }
    }
}
