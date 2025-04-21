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
            //Console.WriteLine("Hello, World!");
            // Enviar un mensaje
            Mensaje mensaje = new Mensaje("Mi primer mensaje", "Este es el cuerpo del mensaje");
            Mensaje.Escuchar(mensaje);
            Console.WriteLine(mensaje.ToString());
            Mensaje mensaje2 = new Mensaje("Mi segundo mensaje", "Este es el cuerpo del 2do mensaje");
            Console.Write(mensaje2.ToString());
            Console.WriteLine(Mensaje.listaDeMensajes);
        }
    }


}
