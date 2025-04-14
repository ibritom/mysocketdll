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
            cliente = new TcpClient();
            cliente.Connect(host, puerto);
            stream = cliente.GetStream();
        }

        public void Enviar(Mensaje mensaje)
        {
            try
            {
                string json = JsonSerializer.Serialize(mensaje);
                byte[] datos = Encoding.UTF8.GetBytes(json);
                stream.Write(datos, 0, datos.Length);
            }
            catch (Exception ex)
            {
                // Log y retry opcional
                throw new IOException("Error enviando mensaje", ex);
            }
        }

        public void Cerrar()
        {
            stream?.Close();
            cliente?.Close();
        }
    }
}
