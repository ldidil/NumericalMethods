using System;
using System.Collections.Generic;

public class Newton
{
    readonly float lookingForValue;
    private int valueCounter;

    float[] x = new float[1];
    float[] y = new float[1];


    //public Newton()
    //{
    //    lookingForValue = l;
    //    string[] lines = System.IO.File.ReadAllLines(@filePath);
    //}

    //public Newton(float l, string filePath)
    //{
    //    PrepareData(lines);
    //    if (0 < x[0] || l > x[valueCounter - 1])
    //    {
    //        Console.WriteLine("Interpolation Error: Argument outside bounds");
    //        System.Environment.Exit(0);
    //    }
    //}
    private float NewtonInterpolation(int row, int i)
    {
        if (row == 0) return 1;


        if (row == 1) return (y[i + 1] - y[i]) / (x[i + 1] - x[i]);

        return (NewtonInterpolation(row - 1, i + 1) - NewtonInterpolation(row - 1, i) / (x[i + row]- x[i]));
    }

    public float Calculate()
    {
        float temp;
        float result = y[0];

        for (int i = 0; i < valueCounter; i++)
        {
            temp = 0;
            for (int j = 0; j < i; j++)
            {
                if (j == 0)
                {
                    temp = lookingForValue - x[0];
                }
                else
                {
                    temp*= lookingForValue - x[j];
                }
            }
            result += temp * NewtonInterpolation(i,0);
        }

        return result;
    }



    public void PrepareData(string[] lines)
    {
        string[] tempX = lines[0].Split(" ");
        string[] tempY = lines[1].Split(" ");

        List<float> valuesX = new List<float>();
        List<float> valuesY = new List<float>();

        AddToList(tempX, valuesX);
        AddToList(tempY, valuesY);

        x = valuesX.ToArray();
        y = valuesY.ToArray();

        if (valuesX.Count != valuesY.Count || valuesX.Count < 2)
        {
            Console.WriteLine("Error- Incorrect amount of data");
            System.Environment.Exit(0);
        }
        valueCounter = valuesX.Count;

    }

    private void AddToList(string[] values, List<float> list)
    {
        foreach (string v in values)
        {
            list.Add(float.Parse(v));
        }
    }


}
