using System;

namespace MetodyNumeryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*lab1
            var l = new Lagrange(4, "../../../LAB1/values.txt");
            Console.WriteLine(l.Calculate());
            */

            //lab2
            Console.WriteLine("Value: ");
            var value = float.Parse(Console.ReadLine());
            var n = new Newton(value, "../../../LAB2/values.txt");
            Console.WriteLine(n.Calculate()); 

        }
    }
}
