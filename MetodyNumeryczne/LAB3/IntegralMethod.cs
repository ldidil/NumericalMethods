using System;
using System.Collections.Generic;

namespace MetodyNumeryczne
{
    class IntegralMethod
    {
        private float firstX;
        private float lastX;

        private int numberOfPoints;

        public List<float> x = new List<float>();


        public IntegralMethod(float first, float last, int n)
        {
            if (last > first)
            {
                firstX = first;
                lastX = last;


                prepareDataFrom(System.IO.File.ReadAllLines("../../../LAB3/values.txt"));

                numberOfPoints = n;

            }
            else
            {
                Console.WriteLine("Incorrect Arguments");
                System.Environment.Exit(0);
            }


        }

        private void prepareDataFrom(string[] values)
        {
            foreach (string v in values)
            {
                x.Add(float.Parse(v));
            }
        }

        public double methodRectangle()
        {
            double result = 0;
            for (float i = firstX + 1; i <= lastX; i += (lastX - firstX) / numberOfPoints)
            {
                result += function(i);
            }
            double dx = (lastX - firstX) / (numberOfPoints);
            result *= dx; return result;
        }

        public double methodTrapezoidal() { 
            double result = 0; for (float i = firstX; i < lastX; i += (lastX - firstX) / numberOfPoints) 
                result += (function(i) + function(i + 1)) / 2;
            double dx = (lastX - firstX) / (numberOfPoints); 
            result *= dx; 
            return result; }

        float function(float j)
        {
            double result = 0;
            int i = 0;
            foreach(float xValue in x)
            {
                result += Math.Pow((double)j, (double)i)* xValue;
                i++;
            }
            return (float)result;
        }

    }


}
