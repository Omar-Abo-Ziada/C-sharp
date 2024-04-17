namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => Console.WriteLine("Foo"));
        }
    }
}
