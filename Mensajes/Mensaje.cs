using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas;

namespace Mensajes
{
    public class Mensaje
    {
        internal static int id {get; private set;}
        public string? usuario { get; internal set; }
        public string? encabezado { get; internal set; }
        public DateTime fecha { get; internal set; }
        internal static Lista<Mensaje> listaDeMensajes = new ListaDobleEnlazada<Mensaje>();

        public int idMensaje { get; private set; }
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
            return this.idMensaje == otro.idMensaje &&
                   this.usuario == otro.usuario &&
                   this.encabezado == otro.encabezado &&
                   this.cuerpo == otro.cuerpo &&
                   this.fecha == otro.fecha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idMensaje, usuario, encabezado, fecha);
        }
        public static void Limpiar()
        {
            listaDeMensajes.Vaciar();
            id = 0;
        }
    }
}
