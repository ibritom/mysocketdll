using Listas;
using Networking;
using Mensajes;
using Interfaces;
namespace MySocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Enviar un mensaje
            Mensaje mensaje = new Mensaje("Mi primer mensaje", "Este es el cuerpo del mensaje");
            Mensaje.Escuchar(mensaje);


        }
    }


}
