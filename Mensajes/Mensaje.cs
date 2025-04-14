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
        private int id;
        private string usuario;
        private string mensaje;
        private DateTime fecha;
        private static Lista<Mensaje> listaDeMensajes = new ListaDobleEnlazada<Mensaje>();

        public int idMensaje { get; private set; }
        public string encabezado { get; set; }
        public string cuerpo { get; set; }

        public Mensaje(string encabezado, string cuerpo)
        {
            idMensaje = id++;
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
        public override bool Equals(object obj)
        {
            if (obj is not Mensaje otro) return false;
            return this.id == otro.id &&
                   this.usuario == otro.usuario &&
                   this.mensaje == otro.mensaje &&
                   this.fecha == otro.fecha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, usuario, mensaje, fecha);
        }
    }
}
