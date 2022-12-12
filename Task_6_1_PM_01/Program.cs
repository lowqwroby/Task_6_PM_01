using System;
using System.Runtime.Serialization.Formatters;

namespace Vareiant10
{
	class Program
	{
		static int[] Input1m()
		{
			Console.Write("Введите размерность массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[n];

			for(int i = 0; i < n; i++)
			{
				Console.Write("a[{0}] = ", i);
				a[i] = Convert.ToInt32(Console.ReadLine());
			}
			return a;
		}

		static void Print1m(int[] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				Console.Write("{0} ", a[i]);
			}
			Console.WriteLine();
		}

		static int Change1m(int[] a, int b, int c)
		{
			int index = 0;
			for(int i = 0; i < a.Length; i++)
			{
				if (a[i] < b || a[i] > c)
				{
					index++;
				}
			}
			return index;
		}

		//

		static int[,] Input2m(out int n,out int m)
		{
			Console.Write("Введите размерность массива: ");
			Console.Write("n = ");
			n = Convert.ToInt32(Console.ReadLine());
			Console.Write("m = ");
			m = Convert.ToInt32(Console.ReadLine());

			int[,] a = new int[n, m];

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < m; j++)
				{
					Console.Write("a[{0}][{1}] = ", i, j);
					a[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			return a;
		}

		static void Print2m(int[,] a)
		{
			for(int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0} ", a[i, j]);
				}
			}
		}

		static int Change2m(int[,] a, int b1, int c1)
		{
			int index = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (a[i, j] >= b1 && a[i, j] <= c1)
					{
						index++;
					}
				}
			}
			return a.Length - index;
		}
		static void Main()
		{
			try
			{
				Console.WriteLine("\tОдномерный массив: ");
				int[] myArray = Input1m();
				int b, c;
				Console.WriteLine("Введите диапазон от а до b");
				Console.Write("a = "); b = Convert.ToInt32(Console.ReadLine());
				Console.Write("b = "); c = Convert.ToInt32(Console.ReadLine());
				if(b > c)
				{
					int temp = c;
					c = b;
					b = temp;
				}
				Console.WriteLine("Исходный массив: ");
				Print1m(myArray);
				Console.WriteLine("Количество элементов вне заданного интервала: {0}", Change1m(myArray, b, c));
				
				Console.WriteLine("\tДвумерный массив");
				int n, m;
				int b1, c1;
				int[,] myArray1 = Input2m(out n, out m);
				Console.WriteLine("Введите диапазон от a до b");
				Console.Write("a[i] = "); b1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("b[i] = "); c1 = Convert.ToInt32(Console.ReadLine());
				if (b > c)
				{
					int temp = c;
					c = b;
					b = temp;
				}
				Console.WriteLine("Исходный массив: ");
				Print2m(myArray1);
				Console.WriteLine("Количество элементов вне заданного интервала: {0}", Change2m(myArray1, b1, c1));
			}
			catch
			{
				Console.WriteLine("Неверно введены значения");
			}
		}
	}
}