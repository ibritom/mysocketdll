using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Mensajes;

namespace Networking
{
    public class MessageProcessor : IMessageProcessor
    {
        public void ProcesarMensaje(Mensaje mensaje)
        {
            Console.WriteLine("Mensaje Recibido");
            Console.WriteLine($"ID: {Mensaje.id}");
            Console.WriteLine($"Encabezado: {mensaje.encabezado}");
            Console.WriteLine($"Cuerpo: {mensaje.cuerpo}");
        }
    }
}
