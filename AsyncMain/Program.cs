using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMain
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 100; i++)
				{
					System.Console.WriteLine(i);
					Thread.Sleep(100);
				}
			});

			System.Console.WriteLine("Program Finished...");
		}
	}
}
