using System;


namespace algorithms
{    //this is part of Coursera course Algorithms Part1
    //https://www.coursera.org/learn/algorithms-part1/home/welcome
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
