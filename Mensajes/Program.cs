namespace Mensajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Mensajes.Mensaje.Limpiar();
            Console.WriteLine($"Mensaje.id = {Mensaje.id}");

        }
    }
}
