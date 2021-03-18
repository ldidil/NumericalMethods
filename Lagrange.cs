using System;
using System.Collections.Generic;

struct Value
{
	float x;
	float y;
}

public class Lagrange
{
	public List<Value> values = new List<Value>();

	public Lagrange(string filePath)
	{
		string[] lines = System.IO.File.ReadAllLines(@filePath);
	}
}
