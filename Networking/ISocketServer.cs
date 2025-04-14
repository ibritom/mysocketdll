using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Networking
{
    public interface ISocketServer
    {
        void Escuchar(int puerto, IMessageProcessor procesador);
        void Detener();
    }
}
