using System;

namespace ConsoleApp1
{
	internal class Program
	{

		static void Main(string[] args)
		{
//1 уровень
#region1
			double r = 2;
			double x, y;
			double[][] a1 = {
			new double[] {0, 2},
			new double[] {1.5, 0.7},
			new double[] {1, 1},
			new double[] {3, 0}
			};
			for (int i = 0; i < 4; i++)
			{
				x = a1[i][0];
				y = a1[i][1];

				if (Math.Abs(x * x + y * y - r * r) <= 0.001)
				{
					Console.WriteLine($"({x}, {y}) lies on a circle");
				}
				else Console.WriteLine($"({x}, {y}) does not lie on a circle");
			}
#endregion

#region2
			double x2 = Convert.ToDouble(Console.ReadLine());
			double y2 = Convert.ToDouble(Console.ReadLine());
			f(y >= 0 && y + Math.Abs(x) <= 1)

			{
				Console.WriteLine("Yes");
			}

			else Console.WriteLine("No");

#endregion

# region3
			double a3 = Convert.ToDouble(Console.ReadLine());
			double b3 = Convert.ToDouble(Console.ReadLine());
			if (a3 > 0)
			{
				Console.WriteLine(Math.Max(a, b));
			}
			else Console.WriteLine(Math.Min(a, b));
#endregion

# region4
			double a4 = Convert.ToDouble(Console.ReadLine());
			double b4 = Convert.ToDouble(Console.ReadLine());
			double c4 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(Math.Max(Math.Min(a4, b4), c4));
#endregion

# region5
			//1
			double r51 = 70;
			double s51 = 36.74;
			double rad_cir1 = Math.Pow((r51 / Math.RI), 0.5);
			double rad_sq1 = Math.Pow(s51,0.5) * Math.Pow(2, 0.5) / 2
			if (rad_cir1 >= rad_sq1)
			{
				Console.WriteLine("Yes");
			}
			else Console.WriteLine("No");

			//2
			double r52 = 0.86;
			double s52 = 0.74;
			double rad_cir2 = Math.Pow((r52 / Math.RI), 0.5);
			double rad_sq2 = Math.Pow(s52, 0.5) * Math.Pow(2, 0.5) / 2
			if (rad_cir2 >= rad_sq2)
			{
				Console.WriteLine("Yes");
			}
			else Console.WriteLine("No");
#endregion

# region6
			double r6 = Convert.ToDouble(Console.ReadLine());
			double s6 = Convert.ToDouble(Console.ReadLine());
			double rad_cir6 = Math.Pow((r6 / Math.RI), 0.5);
			double rad_sq6 = Math.Pow(s6, 0.5) * Math.Pow(2, 0.5) / 2
			if (rad_cir6 <= rad_sq6)
			{
				Console.WriteLine("Yes");
			}
			else Console.WriteLine("No");
#endregion

# region7
			double x7 = Convert.ToDouble(Console.ReadLine());
			if (Math.Abs(x7) > 1)
			{
				Console.WriteLine(1);
			}
			else Console.WriteLine(Math.Abs(x7));
#endregion

# region8
			double x8 = Convert.ToDouble(Console.ReadLine());
			if (Math.Abs(x8) >= 1)
			{
				Console.WriteLine(0);
			}
			else Console.WriteLine(x8 * x8 - 1);

#endregion

# region9
			double x9 = Convert.ToDouble(Console.ReadLine());
			if (x9 <= -1)
			{
				Console.WriteLine(0);
			}
			else if (-1 < x9 && x9 <= 0)
			{
				Console.WriteLine(1 + x9);
			}
			else
			{
				Console.WriteLine(1);
			}
#endregion

//2 уровень
# region2_1
			int n21 = Convert.ToInt32(Console.ReadLine());
			int s21 = 0;
			for (int i = 0; i < n21; ++i)
			{
				s21 += Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine((double)s21 / n21);
#endregion

# region2_2
			int n22 = Convert.ToInt32(Console.ReadLine());
			int a22 = Convert.ToInt32(Console.ReadLine());
			int b22 = Convert.ToInt32(Console.ReadLine());
			int r22 = Convert.ToInt32(Console.ReadLine());
			int kolvo2 = 0;
			for (int i = 0; i < n22; ++i)
			{
				double x22 = Convert.ToDouble(Console.ReadLine());
				double y22 = Convert.ToDouble(Console.ReadLine());

				double d22 = Math.Sqrt(double.Pow(x22-a22, 2) + double.Pow(y22-b22, 2));
				if (d22 <= r22) {
					kolvo2 += 1
						}
				else continue;
			}
			Console.WriteLine(kolvo2);
#endregion

# region2_3
			int n23 = Convert.ToInt32(Console.ReadLine());
			double s23 = 0;
			for (int i = 0; i < n23; i++)
			{
				int weight = Convert.ToInt32(Console.ReadLine());
				if (weight < 30)
				{
					s23 += 0.2;
				}
			}
			Console.WriteLine(s23);
#endregion

# region2_4
			int n24 = Convert.ToInt32(Console.ReadLine());
			double r124 = Convert.ToDouble(Console.ReadLine());
			double r224 = Convert.ToDouble(Console.ReadLine());
			int ans24 = 0;
			for (int i = 0; i < n24; i++)
			{
				double x = Convert.ToDouble(Console.ReadLine());
				double y = Convert.ToDouble(Console.ReadLine());
				if (x * x + y * y <= r224 * r224 && x24 * x24 + y24 * y24 >= r124 * r124)
				{
					++ans24;
				}
			}
			Console.WriteLine(ans24);
#endregion

# region2_5
			int n25 = 30;
			double norma = Convert.ToDouble(Console.ReadLine());
			int ans25 = 0;
			for (int i = 0; i < n25; i++)
			{
				double x25 = Convert.ToDouble(Console.ReadLine());
				if (x25 >= norma)
				{
					++ans25;
				}
			}
			Console.WriteLine(ans25);
#endregion


# region2_6
			int n26 = Convert.ToInt32(Console.ReadLine());
			int ans26 = 0;
			for (int i = 0; i < n26; i++)
			{
				double x26 = Convert.ToDouble(Console.ReadLine());
				double y26 = Convert.ToDouble(Console.ReadLine());
				if (x26 >= 0 && x26 <= Math.PI)
				{
					if (Math.Sin(x26) >= y26 && y26 >= 0)
					{
						++ans26;
					}
				}
			}
			Console.WriteLine(ans26);
#endregion

# region2_7
			int n27 = Convert.ToInt32(Console.ReadLine());
			int ans27_1 = 0;
			int ans27_3 = 0;
			for (int i = 0; i < n27; ++i)
			{
				double x27 = Convert.ToDouble(Console.ReadLine());
				double y27 = Convert.ToDouble(Console.ReadLine());
				if (x27 >= 0 && y27 >= 0)
				{
					Console.WriteLine(1);
					ans27_1++;
				}
				else if (x27 <= 0 && y27 >= 0)
				{
					Console.WriteLine(2);
				}
				else if (x27 <= 0 && y27 <= 0)
				{
					Console.WriteLine(3);
					ans27_3++;
				}
				else
				{
					Console.WriteLine(4);
				}
			}
			Console.WriteLine(ans27);
#endregion

# region2_8
			int n28 = Convert.ToInt32(Console.ReadLine());
			double ans28 = Math.Pow(10.0, 9);
			int num_toch = -1000;
			for (int i = 0; i < n28; ++i)
			{
				double x28 = Convert.ToDouble(Console.ReadLine());
				double y28 = Convert.ToDouble(Console.ReadLine());
				double ans_now = Math.Sqrt(x28 * x28 + y28 * y28);
				if (ans_now < ans28)
				{
					ans28 = ans_now;
					num_toch = i + 1;
				}
			}
			Console.WriteLine(num_toch);
			Console.WriteLine(ans28);
#endregion

# region2_9
			int n29 = Convert.ToInt32(Console.ReadLine());
			double min29 = Math.Pow(10, 9);
			for (int i = 0; i < n29; i++)
			{
				double x29 = Convert.ToDouble((Console.ReadLine()));
				min29 = Math.Min(min29, x29);
			}
			Console.WriteLine(min29);
#endregion
		}
	}
}