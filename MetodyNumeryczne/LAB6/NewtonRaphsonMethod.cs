using System;
namespace MetodyNumeryczne.LAB5
{

    static class NewtonRaphsonMethod
    {
        private const double EPS = 1e-14;
        private static double Func(double x)
        {
            return x * x - 2;
        }
        private static double DFunc(double x)
        {
            return 2*x;
        }


        public static void Calculate(double x0, int n)
        {
            double f0=0;

            while (--n > 0)
            {
              f0 = Func(x0);         // Obliczanie wartości funkcji w punkcie x0 

                if (Math.Abs(f0) < EPS)
                {
                    break;
                }

                var f1 = DFunc(x0);  // Obliczanie wartość pierwszej pochodnej funkcji
                var x1 = x0;
                x0 -= f0 / f1;


                if (Math.Abs(x1 - x0) < EPS)
                {

                    break;
                }
            }
            Console.WriteLine("Value x0 = " + x0);
        }

    }



}

