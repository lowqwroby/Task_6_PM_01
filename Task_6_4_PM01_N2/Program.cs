using System;

namespace Variant10
{
	class Program
	{
		static int[][] Input(int [][]a, int n)
		{
			for(int i = 0; i < n; i++)
			{
				a[i] = new int[n];
				for(int j = 0; j < n; j++)
				{
					Console.Write("a[{0},{1}] = ", i, j);
					a[i][j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			return a;
		} 

		static void Print1(int[] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				Console.Write("{0,5} ", a[i]);
			}
		}

		static void Print2(int[][] a)
		{
			for(int i = 0; i < a.Length; i++, Console.WriteLine())
			{
				for(int j = 0; j < a[i].Length; j++)
				{
					Console.Write("{0,5}", a[i][j]);
				}
			}
		}

		static int[] Max(int[][] a, int n)
		{
			int[] res = new int[n];
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < a[i].Length; j++)
				{	
					if (a[i][j] % 2 == 0)
					{
						res[i] = a[i][j];
					}
				}	
			}
			return res;
		}

		static void Main()
		{
			try
			{
				Console.WriteLine("Введите размерность массива");
				Console.Write("n = ");
				int n = Convert.ToInt32(Console.ReadLine());
				int[][] myArray = new int[n][];
				myArray = Input(myArray, n);
				Console.WriteLine("Исходный массив: ");
				Print2(myArray);
				Console.WriteLine("Массив из последних четных элементов строк: ");
				Print1(Max(myArray, n));
			}
			catch(FormatException)
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