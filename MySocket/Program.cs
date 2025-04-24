using Listas;
using Networking;
using Interfaces;
using Networking;
using System.Net.Http.Json;
using Mensajes;

namespace MySocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el cliente...");
            var cliente = new SocketClient();
            try
            {
                System.Threading.Thread.Sleep(1000);
                cliente.Conectar("127.0.0.1", 5000);
                Mensaje mensaje = new Mensaje("Prueba", "Esto es una prueba");
                cliente.Enviar(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                cliente.Cerrar();
                Console.WriteLine("Desconectó el cliente.");
            }
            Console.ReadLine();
        }
    }


}
