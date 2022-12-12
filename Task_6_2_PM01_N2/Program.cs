using System;

namespace Variant10
{
	class Program
	{
		static double[] Input()
		{
			Console.Write("Введите размерность массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			if(n <= 0)
			{
				throw new FormatException();
			}
			double[] a = new double[n];
			for (int i = 0; i < n; ++i)
			{
				Console.Write("a[{0}] = ", i);
				a[i] = Convert.ToDouble(Console.ReadLine());
			}
			return a;
		}

		static double Min(double[] a)
		{
			double min = a[0];
			int index = 0;
			for (int i = 1; i < a.Length; ++i)
				if (a[i] <= min)
				{
					min = a[i];
					index = i;
				}
			return index;
		}

		static void Main()
		{
			try
			{
				double[] myArray = Input();
				double min = Min(myArray);
				Console.WriteLine("Индекс последнего минимального элемента: {0}", min);
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный ввод данных");
			}
			catch
			{
				Console.WriteLine("Что-то пошло не так...");
			}
		}
	}
}
