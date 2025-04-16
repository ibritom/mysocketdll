using Mensajes;
namespace Mensajes.Pruebas
{
    [TestClass]
    public sealed class MensajePruebas
    {
        [TestMethod]
        public void idPruebas()
        {
            // Arrange
            Mensajes.Mensaje.Limpiar();
            var mensaje1 = new Mensaje("Encabezado", "Cuerpo");
            var mensaje2 = new Mensaje("Encabezado", "Cuerpo");
            // Act
            int valor = Mensajes.Mensaje.id;
            // Assert
            Assert.AreEqual(2, valor, "El id no es el esperado");

        }
        [TestMethod]
        public void idMensajePruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            var mensaje2 = new Mensaje("Encabezado", "Cuerpo");
            // Act
            // Assert
            Assert.AreNotEqual(mensaje.idMensaje, mensaje2.idMensaje);
        }
        [TestMethod]
        public void UsuarioPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            mensaje.usuario = "Usuario";
            // Assert
            Assert.AreEqual("Usuario", mensaje.usuario);
        }
        [TestMethod]
        public void EncabezadoPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            mensaje.encabezado = "Encabezado";
            // Assert
            Assert.AreEqual("Encabezado", mensaje.encabezado);
        }
        [TestMethod]
        public void FechaPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            mensaje.fecha = DateTime.Now;
            // Assert
            Assert.AreEqual(DateTime.Now.Date, mensaje.fecha.Date);
        }
        [TestMethod]
        public void CuerpoPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            mensaje.cuerpo = "Cuerpo";
            // Assert
            Assert.AreEqual("Cuerpo", mensaje.cuerpo);
        }
        [TestMethod]
        public void EscucharPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            Mensaje.Escuchar(mensaje);
            // Assert
            Assert.IsTrue(Mensaje.listaDeMensajes.Contiene(mensaje));
        }
        [TestMethod]
        public void ToStringPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            string valor = mensaje.ToString();
            // Assert
            Assert.AreEqual($"[{mensaje.idMensaje}] {mensaje.encabezado}: {mensaje.cuerpo}", valor);
        }
        [TestMethod]
        public void EqualsPruebas()
        {
            // Arrange
            var mensaje1 = new Mensaje("Encabezado", "Cuerpo");
            var mensaje2 = new Mensaje("Encabezado", "Cuerpo");
            // Act
            bool valor = mensaje1.Equals(mensaje2);
            // Assert
            Assert.IsFalse(valor);
        }
        [TestMethod]
        public void GetHashCodePruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            int valor = mensaje.GetHashCode();
            // Assert
            Assert.AreNotEqual(0, valor);
        }
        [TestMethod]
        public void ConstructorPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            // Act
            // Assert
            Assert.AreEqual("Encabezado", mensaje.encabezado);
            Assert.AreEqual("Cuerpo", mensaje.cuerpo);
            Assert.AreEqual(0, mensaje.idMensaje);
            Assert.AreEqual(null, mensaje.usuario);
            Assert.AreEqual(DateTime.MinValue, mensaje.fecha);
        }
        [TestMethod]
        public void LimpiarPruebas()
        {
            // Arrange
            var mensaje = new Mensaje("Encabezado", "Cuerpo");
            Mensaje.Escuchar(mensaje);
            // Act
            Mensaje.Limpiar();
            // Assert
            Assert.IsTrue(Mensaje.listaDeMensajes.RevisarVacio());
        }
    }
}
