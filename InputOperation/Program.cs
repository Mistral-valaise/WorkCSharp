using System;

namespace InputOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Zahl1: ");
            double value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie Zahl2: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine(value1 + " + " + value2 + " = " + (value1 + value2));
            Console.WriteLine(value1 + " - " + value2 + " = " + (value1 - value2));
            Console.WriteLine(value1 + " x " + value2 + " = " + (value1 * value2));
            Console.WriteLine(value1 + " : " + value2 + " = " + (value1 / value2));
            Console.WriteLine(value1 + " % " + value2 + " = " + (value1 % value2));

        }
    }
}
