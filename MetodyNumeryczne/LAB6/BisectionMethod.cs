using System;
namespace MetodyNumeryczne.LAB5
{

    static class BisectionMethod
    {
        private const double EPS = 1e-14;


        private static double Func(double x)
        {
            return (x * x * x + x * x - 3 * x - 3);
        }


        public static void Calculate(double a, double b)
        {
            var fa = Func(a); // Obliczanie wartości funkcji na krańcach przedziału [a,b] 
            var fb = Func(b);

            if (fa * fb > 0)
            {
                Console.Write("ERROR, Incorect Data");
                System.Environment.Exit(0);
            }
            double x0;

            while (true)
            {

                x0 = (a + b) / 2; // Wyznaczenie środka przedziału [a,b] 

                if (Math.Abs(a - x0) < EPS)
                    break;
                if (Math.Abs(Func(x0)) < EPS)
                    break;

                if (fa * Func(x0) < 0) b = x0;
                else
                {
                    a = x0;
                    fa = Func(x0);
                }
            }

            Console.WriteLine("Value x0 = " + x0);
            Console.WriteLine("Value f(x0) = " + Func(x0));
        }

    }



}

