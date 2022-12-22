using System;

namespace bos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A-ni daxil et:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("B-ni daxil et:");
            double b = Convert.ToDouble(Console.ReadLine());


            double c = a + b;

            Console.WriteLine($"{a}+{b}={c}");
        }
    }
}