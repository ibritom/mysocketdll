using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Nodo<Tipo>
    {
        public Tipo valor { get; set; }
        public Nodo<Tipo> siguiente { get; set; }

        public Nodo<Tipo> anterior { get; set; }
        public Nodo(Tipo valor)
        {
            this.valor = valor;
            this.siguiente = null;
            this.anterior = null;
        }
        public override bool Equals(object obj)
        {
            if (obj is not Nodo<Tipo> otro) return false;
            return EqualityComparer<Tipo>.Default.Equals(this.valor, otro.valor);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<Tipo>.Default.GetHashCode(this.valor);
        }
    }
}
