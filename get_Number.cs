using System;
namespace Assignment3
{
	partial class Interest
	{

		// In this function, we defined that we will return a double array
		public static double[] get_user_inputs()
		{

			// Defined 3 input array (investment, time, rate)
			double[] amt_year_rate = new double[3];

			//We take 3 inputs from user and convert them to double.
			Console.WriteLine("Please enter the INVESTMENT AMOUNT");
			double investment = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the end of INVESTMENT PERIOD in YEARS");
			double time = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the RATE OF INTEREST\nFor Example: If the rate is ' 6% ' ENTER ' 0.06' ");
			double rate = Convert.ToDouble(Console.ReadLine());

			//We assigned these 3 inputs to an array.
			amt_year_rate[0] = investment;
			amt_year_rate[1] = time;
			amt_year_rate[2] = rate;

			//And returned the array here.
			return amt_year_rate;


		}
	}
}

