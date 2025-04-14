using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;

namespace Networking
{
    public interface ISocketClient
    {
        void Conectar(string host, int puerto);
        void Enviar(Mensaje mensaje);
        void Cerrar();
    }
}
