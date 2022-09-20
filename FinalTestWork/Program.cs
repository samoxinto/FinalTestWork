using System;

namespace FinalTestWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string[] array = { "hello", "2", "world", "jerk", "an" };
			string[] result = { };

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length <= 3)
				{
					Array.Resize(ref result, result.Length + 1);
					result[result.Length - 1] = array[i];
				}
			}

			Console.WriteLine(string.Join(" ", result));
			Console.ReadLine();
		}
    }
}
