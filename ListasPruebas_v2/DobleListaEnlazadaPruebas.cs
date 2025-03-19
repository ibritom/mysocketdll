using Listas;

namespace ListasPruebas_v2;

[TestClass]
public sealed class DobleListaEnlazadaPruebas
{
    [TestMethod]
    public void Vaciar_FuncionaCorrectamente()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();


        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);
        lista_aVerificar.Vaciar();

        var valorLista = lista_aVerificar.ToString();

        Assert.AreEqual("", valorLista, "La lista no es nula");

    }

    [TestMethod]
    public void RevisarVacio_BooleanoCorrecto1()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool valorBooleanoEsperado = false;

        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);

        bool valorBooleanoRevisarVacio = lista_aVerificar.RevisarVacio();

        Assert.AreEqual(valorBooleanoEsperado, valorBooleanoRevisarVacio, "La lista no est� vac�a o RevisarVacio() no da la respuesta False esperada");


    }

    [TestMethod]
    public void RevisarVacio_BooleanoCorrecto2()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool valorBooleanoEsperado = true;

        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);
        lista_aVerificar.Vaciar();

        bool valorBooleanoRevisarVacio = lista_aVerificar.RevisarVacio();

        Assert.AreEqual(valorBooleanoEsperado, valorBooleanoRevisarVacio, "La lista est� vac�a o RevisarVacio() no da la respuesta True esperada");


    }

    [TestMethod]
    public void Tamano_EnteroCorrecto()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        int valorEnteroEsperado = 3;

        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);

        int resultado = lista_aVerificar.Tamano();

        Assert.AreEqual(valorEnteroEsperado, resultado, "La lista no es del tama�o esperado o Tamano() no da el valor correcto del tama�o de la lista");
    }

    [TestMethod]
    public void Contiene_BooleanoCorrecto1()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool valorBooleanoEsperado = true;

        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);

        int valor = 1;

        bool valorBooleanoContiene = lista_aVerificar.Contiene(valor);

        Assert.AreEqual(valorBooleanoEsperado, valorBooleanoContiene, "Contiene() no da la respuesta true esperada");


    }

    [TestMethod]
    public void Contiene_BooleanoCorrecto2()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool valorBooleanoEsperado = false;

        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(3);
        lista_aVerificar.Anadir(44);

        int valor = 8;

        bool valorBooleanoContiene = lista_aVerificar.Contiene(valor);

        Assert.AreEqual(valorBooleanoEsperado, valorBooleanoContiene, "Contiene() no da la respuesta true esperada");


    }

    [TestMethod]
    public void Anadir_FuncionaCorrectamente()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool valorBooleanoEsperado = true;

        lista_aVerificar.Anadir(1);

        int valor = 1;

        bool valorBooleanoContiene = lista_aVerificar.Contiene(valor);

        Assert.AreEqual(valorBooleanoEsperado, valorBooleanoContiene, "Anadir no agreg� el valor 1, respuesta esperada true");
    }

    [TestMethod]
    public void Borrar_FuncionaCorrecta()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        bool prueba;
        bool respuestaEsperada = true;
        lista_aVerificar.Anadir(1);
        lista_aVerificar.Anadir(1);
        int tamanoAnterior;
        tamanoAnterior = lista_aVerificar.Tamano();
        lista_aVerificar.Borrar(1);
        var tamanoActual = lista_aVerificar.Tamano();
        prueba = lista_aVerificar.Contiene(1) || tamanoAnterior > tamanoActual;
        Assert.AreEqual(respuestaEsperada, prueba, "El elemento no fue eliminado adecuadamente");
    }

    [TestMethod]
    public void ToString_StringCorrecto()
    {
        Lista lista_aVerificar = new ListaDobleEnlazada<int>();
        string stringEsperado = "[2, 3]";

        lista_aVerificar.Anadir(2);
        lista_aVerificar.Anadir(3);

        string stringlista_aVerificar = lista_aVerificar.ToString();

        Assert.AreEqual(stringEsperado, stringlista_aVerificar, "No se obtiene el valor de string que correponde con la lista");
    }
}
