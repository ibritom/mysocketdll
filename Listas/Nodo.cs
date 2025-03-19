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
        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
            this.anterior = null;
        }
    }
}
