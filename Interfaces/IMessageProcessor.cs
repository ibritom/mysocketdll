using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas;
using Mensajes;

namespace Interfaces
{
    public interface IMessageProcessor
    {
        void ProcesarMensaje(Mensaje mensaje);
    }
}
