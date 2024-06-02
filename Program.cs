
/*

============================================================
File: Assignment3.cs		Course: CSIS 1175 – Assignment 3

Author: Ali Surmeli			Student Number: 300355214
Course: CSIS 1175 003/050


Email: surmelia@student.dougascollege.ca
Date: July 31, 2022
=============================================================
	
Purpose: The purpose of this program is to calculate the investemnt return,
based on the annual rate, amount of money that will be invested and how many
years does user wants to invest. We ask user to enter 3 input;
- annual investment rate
- how many years to invest
- What is the investment amount

and we return the investment return step by step(year by year) based on
manual calculation we made in a function.

NOTE: RUN THE EXE FILE OR 'RUN WITHOUT DEBUGGING' if you use VSCode.

*/

namespace Assignment3

{
    class Program
    {
        static void Main(string[] args)
        {


            //First function to get user inputs as an double array;
            //Here we took 3 inputs in one function
            double[] userInput = Interest.get_user_inputs();


            //In calculate income function, we give 3 input to function
            //Return investment return year by year
            double[] yearly_results =Interest.calculate_Income(userInput);


            //Display result function prompt the function in Console
            Interest.display_Result(yearly_results);
            

            Console.ReadKey();

            return;
        }
    }

}