using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using Interfaces;

namespace Networking
{
    public class RetryPolicy
    {
        public static void EjecutarConReintento(Action accion, int reintentos = 3, int tiempoEsperaMs = 1000)
        {
            int intentos = 0;
            while (true)
            {
                try
                {
                    accion();
                    break;
                }
                catch
                {
                    intentos++;
                    if (intentos >= reintentos) throw;
                    Thread.Sleep(tiempoEsperaMs);
                }
            }
        }
    }
}
