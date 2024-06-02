using System;
namespace Assignment3
{
	public partial class Interest
	{
		public static void display_Result(double[] results)
		{
			// We define this function to prompt user the results

			int i;

			// we can create a loop limited on the lenght of the array.
			//Then prompt the results.
			int year = results.Length;
			Console.WriteLine(year);

			for(i=1; i<=year; i++)
            {

				Console.WriteLine("By the end of " + i + " year, investment return will be {0:c}", results[i-1]);

            }

		}
	}
}

