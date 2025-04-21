using Listas;
using Networking;
using Mensajes;
using Interfaces;
using Networking;
namespace MySocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            SocketClient cliente = new SocketClient();
            cliente.Conectar("127.0.0.1", 5000);
        }
    }


}
