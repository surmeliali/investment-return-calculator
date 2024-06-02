using System;
namespace Assignment3
{
	partial class Interest
	{

		//We specified that we will return a double array
		public static double[] calculate_Income(double[] investment)
		{
			
			// First we take all elements that we take from function.
			// Also define i, interest_result and results array.
			double amount = investment[0];
			int year = Convert.ToInt32(investment[1]);
			double rate = investment[2];
			int i;

			double interest_result = 1;
			double[] results = new double[year];


			//We created a loop that calculates the rate for each year and
			//add them to our results[] function.
			for (i = 1; i <= year; i++)
            {
				//result = Math.Pow(1+rate , i);
				//Instead of doing it with Math.Pow, we will make it manually.

				interest_result *= (1 + rate);
				results[i - 1] = amount*interest_result;

			}
			//Return results array.
			return results;
		}
	}
}

