using System;

namespace IgnoredMethodResponse
{
	class Program
	{
		static void Main(string[] args)
		{
			var (sum, mean) = Add(1, 2, 3);
			System.Console.WriteLine($"Total: {sum}, Mean: {mean}");

			// You can use _ (discard) for unused variables.
			var (total, _) = Add(4, 5, 6);
			System.Console.WriteLine($"Total: {total}");
		}

		public static (int sum, double mean) Add(params int[] numbers)
		{
			var sum = 0;
			foreach (var number in numbers)
				sum += number;

			var mean = sum / numbers.Length;

			return (sum, mean);
		}
	}
}
