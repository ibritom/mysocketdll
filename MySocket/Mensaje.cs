using Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocket
{
    public class Mensaje
    {
        private static int contadorId;
        private static Lista<Mensaje> listaDeMensajes = new ListaDobleEnlazada<Mensaje>();
        public int idMensaje { get; set; }
        public string encabezado { get; set; }
        public string cuerpo { get; set; }

        public Mensaje(string encabezado, string cuerpo)
        {
            //if (contadorId == 0) contadorId = 0;
            idMensaje = contadorId;
            this.encabezado = encabezado;
            this.cuerpo = cuerpo;
            contadorId++;
        }

        public static void Escuchar(Mensaje mensaje)
        {
            listaDeMensajes.Anadir(mensaje);
        }

    }
}
