using System;

namespace Algorithm
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] arr_temp = Console.ReadLine().Split(' ');
			int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
			int length = arr.Length;
			int total = 0;
			for (int i = 0; i < n; i++)
			{
				total = total + arr[i];
				
			}
			Console.Write(total);
			Console.ReadKey();
		}
	}
}
