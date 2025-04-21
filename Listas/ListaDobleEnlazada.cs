using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaDobleEnlazada<Tipo> : Lista<Tipo>
    {
        internal Nodo<Tipo> cabeza;
        internal int tamano;
        public ListaDobleEnlazada()
        {
            this.cabeza = null;
            this.tamano = 0;
        }
        public void Vaciar()
        {
            this.cabeza = null;
            this.tamano = 0;
        }
        public bool RevisarVacio()
        {
            return this.tamano == 0;
        }
        public int Tamano()
        {
            return this.tamano;
        }
        public bool Contiene(Tipo elemento)
        {
            Nodo<Tipo> actual = this.cabeza;
            while (actual != null)
            {
                if (Equals(actual.valor, elemento))
                {
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }
        public bool Anadir(Tipo elemento)
        {
            Nodo<Tipo> nuevoNodo = new Nodo<Tipo>(elemento);
            if (this.cabeza == null)
            {
                this.cabeza = nuevoNodo;
            }
            else
            {
                Nodo<Tipo> actual = this.cabeza;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevoNodo;
                nuevoNodo.anterior = actual;
            }
            this.tamano++;
            return true;
        }
        public Tipo Borrar(Tipo elemento)
        {
            if (this.cabeza == null)
            {
                throw new KeyNotFoundException();
            }
            if (Equals(this.cabeza.valor, elemento))
            {
                this.cabeza = this.cabeza.siguiente;
                if (this.cabeza != null)
                {
                    this.cabeza.anterior = null;
                }
                this.tamano--;
                return elemento;
            }
            Nodo<Tipo> actual = this.cabeza;
            while (actual.siguiente != null)
            {
                if (Equals(actual.siguiente.valor, elemento))
                {
                    actual.siguiente = actual.siguiente.siguiente;
                    if (actual.siguiente != null)
                    {
                        actual.siguiente.anterior = actual;
                    }
                    this.tamano--;
                    return elemento;
                }
                actual = actual.siguiente;
            }
            throw new KeyNotFoundException();
        }
        public override string ToString()
        {
            return ToString_aux();
        }
        public string ToString_aux()
        {
            Nodo<Tipo> actual = this.cabeza;
            try
            {
                while (actual != null)
                {
                    string stringLista = "";
                    var rango = Enumerable.Range(0, this.Tamano());
                    foreach (var i in rango)
                    {
                        if (stringLista != "")
                        {
                            stringLista = stringLista + ", " + actual.valor;
                            actual = actual.siguiente;
                        }
                        else
                        {
                            stringLista = stringLista + actual.valor;
                            actual = actual.siguiente;
                        }

                    }
                    return "\n[" + stringLista + "]";
                }
                return "";
            }
            catch
            {
                return "Error mostrando el contenido de la lista";

            }

        }
        public override bool Equals(object obj)
        {
            if (obj is not ListaDobleEnlazada<Tipo> otra) return false;
            if (this.tamano != otra.tamano) return false;

            Nodo<Tipo> actual = this.cabeza;
            Nodo<Tipo> otroActual = otra.cabeza;

            while (actual != null)
            {
                if (!EqualityComparer<Tipo>.Default.Equals(actual.valor, otroActual.valor))
                    return false;
                actual = actual.siguiente;
                otroActual = otroActual.siguiente;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = tamano;
            Nodo<Tipo> actual = cabeza;
            while (actual != null)
            {
                hash = HashCode.Combine(hash, EqualityComparer<Tipo>.Default.GetHashCode(actual.valor));
                actual = actual.siguiente;
            }
            return hash;
        }
    }
}
