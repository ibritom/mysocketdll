using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Mensajes;
using Interfaces;

namespace Networking
{
    public class SocketClient : ISocketClient
    {
        private TcpClient cliente;
        private NetworkStream stream;

        public void Conectar(string host, int puerto)
        {
            cliente = new TcpClient(host, puerto);
            stream = cliente.GetStream();
        }

        public void Enviar(Mensaje mensaje)
        {
            try
            {
                string json = JsonSerializer.Serialize(mensaje);
                byte[] datos = Encoding.UTF8.GetBytes(json);
                byte[] longitud = BitConverter.GetBytes(datos.Length);
                Console.WriteLine($"Enviando la longitud del mensaje: {datos.Length}");
                stream.Write(longitud, 0, longitud.Length);
                stream.Write(datos, 0, datos.Length);
            }
            catch (Exception ex)
            {
                throw new IOException("Error enviando mensaje", ex);
            }
        }

        public void Cerrar()
        {
            stream.Close();
            cliente.Close();
        }
    }
}
