using System;


namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, in this project : ");

            var qf = new QuickFind(9);
            Console.WriteLine($"Hello World! {qf.ReturnMessage()}");

            qf.Run();
        }
    }
}
