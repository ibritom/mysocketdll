namespace Networking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el servidor...");
            var server = new SocketServer();
            var processor = new MessageProcessor();

            try
            {
                server.Escuchar(5000, processor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
