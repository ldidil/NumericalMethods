﻿using MetodyNumeryczne.LAB5;
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
            //Console.WriteLine("Value: ");
            //var value = float.Parse(Console.ReadLine());
            //var n = new Newton(value, "../../../LAB2/values.txt");
            //Console.WriteLine(n.Calculate()); 

            ////lab3

            //Console.WriteLine("Podaj poczatek przedzialu calkowania");
            //float xp = float.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj koniec przedzialu calkowania");
            //float xk = float.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj dokladnosc calkowania");
            // int n = int.Parse(Console.ReadLine());

            //var v = new IntegralMethod(xp, xk, n);

            //Console.WriteLine("Wartosc calki wynosi w przyblizeniu: ");

            //Console.WriteLine("Dla metody prostokatow: " + v.methodRectangle());

            //Console.WriteLine("Dla metody trapezow: " + v.methodTrapezoidal());

            //lab3
            BisectionMethod.Calculate(1,2);

        }
    }
}
