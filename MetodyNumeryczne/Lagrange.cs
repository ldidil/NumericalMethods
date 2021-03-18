using System;
using System.Collections.Generic;



public class Lagrange
{
    readonly float lookingForValue;
	private int valueCounter;

	public List<float> valuesX = new List<float>();
	public List<float> valuesY = new List<float>();

	public Lagrange()
	{
	}

	public Lagrange(float x,string filePath)
	{
		lookingForValue = x;
		string[] lines = System.IO.File.ReadAllLines(@filePath);
		PrepareData(lines);
	}

    public float Calculate()
    {
		var tempX = valuesX.ToArray();
		var tempY = valuesY.ToArray();
		float result = 0;
		;
		for (int i = 0; i < valueCounter; i++)
        {
			float l = 1;

			for (int j = 0; j < valueCounter; j++)
			{				
				if (i != j)
                {
                    l = l * (lookingForValue - tempX[j]) / (tempX[i] - tempX[j]);

				}
			}

			result += l* tempY[i];

		}

		return result;

	}

    public bool PrepareData(string[] lines)
    {
		string[] tempX = lines[0].Split(" ");
		string[] tempY = lines[1].Split(" ");
		AddToList(tempX, valuesX);
		AddToList(tempY, valuesY);
		if(valuesX.Count != valuesY.Count || valuesX.Count<3)
        {
			Console.WriteLine("error");
			return false;
        }
		valueCounter = valuesX.Count;
		return true;
		
	}

    private void AddToList(string[] values, List<float> list)
    {
		foreach (string v in values)
		{
            list.Add(float.Parse(v));
		}
    }


}
