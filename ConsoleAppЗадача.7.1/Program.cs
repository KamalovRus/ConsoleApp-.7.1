using System;

public class Test
{
	static double Ploshad(int A, int B, int C)
	{
		double p = (A + B + C) / 2;
		double ans = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		return ans;
	}
	public static void Main()
	{
		int tr1A = 2, tr1B = 3, TR1C = 3;
		int tr2A = 1, tr2B = 1, TR2C = 1;
		double p1 = Ploshad(tr1A, tr1B, TR1C);
		double p2 = Ploshad(tr2A, tr2B, TR2C);
		if (p1 < p2)
		{
			p2 = Math.Round(p2, 2);
			Console.WriteLine("Площадь второго больше и равна {0:0.00}", p2);
		}
		else
		{
			p1 = Math.Round(p1, 2);
			Console.WriteLine("Площадь певрого больше и равна {0}", p1);
			Console.ReadKey();
		}
	}
}