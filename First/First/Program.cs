using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(3.4, 1);

            Console.WriteLine("Multiplication: "+fraction.Multiplication);
            Console.WriteLine("Division: "+fraction.Division);
            Console.WriteLine("Substraction: "+fraction.Subtraction);
            Console.WriteLine("Addition: "+fraction.Addition);

            Console.ReadLine();
        }
    }
}
