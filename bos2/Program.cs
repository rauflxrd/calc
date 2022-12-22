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

            Console.WriteLine("C-ni daxil et:");
            double c = Convert.ToDouble(Console.ReadLine());
            
            double d = a * b * c;

            Console.WriteLine($"{a}*{b}*{c}={d}");
        }
    }
}