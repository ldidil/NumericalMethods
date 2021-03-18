using System;

namespace MetodyNumeryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new Lagrange(4, "../../../values.txt");
            Console.WriteLine(l.Calculate());;
        }
    }
}
