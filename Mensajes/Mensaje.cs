using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas;

namespace Mensajes
{
    internal class Mensaje
    {
        private static int contadorId;
        private static Lista<Mensaje> listaDeMensajes = new ListaDobleEnlazada<Mensaje>();

        public int idMensaje { get; private set; }
        public string encabezado { get; set; }
        public string cuerpo { get; set; }

        public Mensaje(string encabezado, string cuerpo)
        {
            idMensaje = contadorId++;
            this.encabezado = encabezado;
            this.cuerpo = cuerpo;
        }

        public static void Escuchar(Mensaje mensaje)
        {
            listaDeMensajes.Anadir(mensaje);
        }

        public override string ToString()
        {
            return $"[{idMensaje}] {encabezado}: {cuerpo}";
        }
    }
}
