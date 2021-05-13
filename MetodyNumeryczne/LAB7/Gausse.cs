using System;

namespace MetodyNumeryczne.LAB7
{

    class Gausse
    {
        private static double[] weight = { 1, 1 };
        private static double[] point = { -0.5773502692, 0.5773502692 };

        public static double Calculate(double[] x, double[] y)
        {

            double[,] Ksi = new double[2, 4];
            double[,] Eta = new double[2, 4];
            double[,] Detj = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                Eta[i, 0] = -0.25 * (1.0 - point[i]);
                Eta[i, 1] = -0.25 * (1.0 + point[i]);
                Eta[i, 2] = 0.25 * (1.0 + point[i]);
                Eta[i, 3] = 0.25 * (1.0 - point[i]);

                Ksi[i, 0] = -0.25 * (1.0 - point[i]);
                Ksi[i, 1] = 0.25 * (1.0 - point[i]);
                Ksi[i, 2] = 0.25 * (1.0 + point[i]);
                Ksi[i, 3] = -0.25 * (1.0 + point[i]);

            }


            double dxdKsi, dydKsi, dxdEta, dydEta;

            for (int i = 0; i < 2; i++)
            {
                dxdKsi = Ksi[i, 0] * x[0] + Ksi[i, 1] * x[1] + Ksi[i, 2] * x[2] + Ksi[i, 3] * x[3];
                dydKsi = Ksi[i, 0] * y[0] + Ksi[i, 1] * y[1] + Ksi[i, 2] * y[2] + Ksi[i, 3] * y[3];
                for (int j = 0; j < 2; j++)
                {

                    dxdEta = Eta[j, 0] * x[0] + Eta[j, 1] * x[1] + Eta[j, 2] * x[2] + Eta[j, 3] * x[3];
                    dydEta = Eta[j, 0] * y[0] + Eta[j, 1] * y[1] + Eta[j, 2] * y[2] + Eta[j, 3] * y[3];
                    Detj[i, j] = (dxdKsi * dydEta) - (dydKsi * dxdEta);
                }
            }

            double result = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result += Math.Abs(Detj[i, j])*weight[i]*weight[j];

                }
            }
            return result;
        }

    }



}
