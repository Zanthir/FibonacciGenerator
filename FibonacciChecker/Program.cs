using System;
using System.Linq;

namespace FibonacciChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int i = 10; i <= 40; i++)
			{
				Console.WriteLine(CalculateFibonacci(i));
			}
			Console.ReadLine();
		}

		public static int CalculateFibonacci(int position)
		{
			var previousResult = 0;
			var result = 1;
			for (var i = 0; i < position; i++)
			{
				result = previousResult + result;
				previousResult = result - previousResult;
			}
			return result;
		}
	}
}
