using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public interface Lista<Tipo>
    {
        public void Vaciar();
        public bool RevisarVacio();

        public int Tamano();
        public bool Contiene(Tipo elemento);
        public bool Anadir(Tipo elemento);
        public int Borrar(Tipo elemento);

    }
}
