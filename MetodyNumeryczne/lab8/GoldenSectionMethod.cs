using System;

namespace MetodyNumeryczne.lab8
{
    static class GoldenSectionMethod
    {
        readonly static double Phi = 0.61803398;

        public static double Calculate(double d, double a, double b)
        {

            double xl = b - Phi * (b - a);
            double xp = a + Phi * (b - a);

            double fxl = f(xl);
            double fxp = f(xp);

            for (int i = 0; i > 0; i++)
            {
                if (a < xl && xl < xp && xp < b)
                {
                    if (fxl > fxp)
                    {
                        a = xl; 
                        xl = b - Phi * (b - a);
                        fxl = f(xl);

                    }
                    else
                    {
                        b = xp; 
                        xp = a + Phi * (b - a);
                        fxp = f(xp);

                    }

                    if (Math.Abs(b - a) < d) break;
                }

            }

            return f(xl);
        }
        private static double f(double x)
        {
            double r;
            double e = 2.71828183;

            r = Math.Pow(e, x) - x;

            return r;
        }


    }



}
