using System;

namespace Exitting
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				System.Console.WriteLine("An argument expected. Use 0 or 1");
				Environment.Exit(1);
			}

			switch (args[0])
			{
				case "0":
					Environment.Exit(0);
					break;
				case "1":
					Environment.Exit(1);
					break;
				default:
					System.Console.WriteLine("Wrong argument, Use 0 or 1");
					break;
			}
		}
	}
}
