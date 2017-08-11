using System;
using System.Linq;

namespace FibonacciChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			var arg = args.FirstOrDefault();
			var result = -1;
			while (true)
			{
				Int32.TryParse(arg, out result);
				if (result != -1)
				{
					Console.WriteLine(CalculateFibonacci(result));
				}
				else
				{
					Console.WriteLine("Failure to parse input value.");
				}
				arg = Console.ReadLine();
			}
		}

		public static int CalculateFibonacci(int position)
		{
			var previousResult = 1;
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
