using System;
using System.Globalization;

namespace Variant10
{
	class Program
	{
		static int[,] Input(out int n)
		{
			Console.WriteLine("Введите размерность массива");
			Console.Write("n = ");
			n = Convert.ToInt32(Console.ReadLine());
			if(n <= 0)
			{
				throw new FormatException();
			}
			int[,] a = new int[n, n];
			
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.Write("a[{0}, {1}] = ", i, j);
					a[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			return a;
			
		}

		static void Print(int[,] a)
		{
			for(int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0,5} ", a[i, j]);
				}
			}
		}

		static int[,] Result(int[,] a, int m)
		{
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = (int)Math.Pow(a[i, j], m);
				}
			}
			return a;
		}

		static void Main()
		{
			try
			{
				int n;
				int[,] myArray = Input(out n);
				if(n <= 0)
				{
					throw new FormatException();
				}
				Console.WriteLine("Исходный массив: ");
				Print(myArray);
				Result(myArray, n);
				Console.WriteLine("Массив, элементы которого были возведены в степень n: ");
				Print(myArray);
			}
			catch (FormatException)
			{
				Console.WriteLine("Введены неверные данные");
			}
			catch
			{
				Console.WriteLine("Что-то пошло не так");
			}
			
		}
	}
}