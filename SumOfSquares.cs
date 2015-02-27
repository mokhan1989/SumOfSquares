/* 
   Author: Mohammad Hyderkhan
   Date: 25/02/2015
   Framework: .Net v4.5
   Compiler: .Net 4.5
   Project Type: Console application
   Language: C#
   Description: A c# console application that calculates the sum of the first 100 squared numbers.
   				The second part calculates the sum of the first 100 numbers, squares it, and finds 
				the difference between this number and the sum of each number squared.
*/
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Initialise a variable to store the sum of the first 100 squared numbers
		double sumOfSquaredNumbers = 0;
		
		//Initialise a variable to store the sum of the first 100 numbers
		double squareOfSum = 0;
		
		List<double> natNumbersList = new List<double>();
		List<double> powerOfNatNumbersList = new List<double>();
		
		Console.WriteLine("The squared version of the first 100 numbers is: ");
		
		for(double i = 1; i <= 100; i++)
		{
			//A temporary variable to hold the current number
			double currentNumber = i;
			
			natNumbersList.Add(currentNumber);
			
			//A variable to calculate and hold the squared version of the natural number
			double powerOfNatNumber = Math.Pow(currentNumber, 2);
			
			powerOfNatNumbersList.Add(powerOfNatNumber);
			
			//A variable to hold the total of squared computated numbers and the squared version of the current number
			sumOfSquaredNumbers = sumOfSquaredNumbers + powerOfNatNumber;
			
			//A variable to hold the total of computated numbers and the current number
			squareOfSum = squareOfSum + currentNumber;
			
			//Display the current number thats being iterated and its squared version to the console
			Console.WriteLine(currentNumber + " ^ 2 = " + powerOfNatNumber);				
		}
		
		//Convert list to a readable format using string concatenation
		string concatPowerOfNatNumbers = string.Join(" + ", powerOfNatNumbersList);
		string concatNatNumbers = string.Join(" + ", natNumbersList);
		
		//A variable to calculate and hold the squared version of the sum of natural numbers
		double powerOfSum = Math.Pow(squareOfSum, 2);
		
		//A variable to calculate the difference between the squared version of the sum of natural numbers and the sum of squared totals
		double difference = powerOfSum - sumOfSquaredNumbers;
		
		Console.WriteLine();
		
		//Display the Sum of squared total to the console
		Console.WriteLine("The total of squared numbers from 1 to 100 = " + concatPowerOfNatNumbers + " = " + sumOfSquaredNumbers);
		
		Console.WriteLine();
		
		//Display the squared version of the sum of natural numbers to the console
		Console.WriteLine("The sum of all numbers = " + concatNatNumbers + " = " + squareOfSum);
		
		Console.WriteLine();
		
		//Display the sum of natural numbers and the squared version of that number 
		Console.WriteLine("The sum of all numbers to the power of 2 = " + squareOfSum + " ^ 2 = " + powerOfSum);
		
		Console.WriteLine();
		
		//Display the difference between the squared sum and the total of squared numbers
		Console.WriteLine("The difference between the sum of squared total and the squared sum = " + powerOfSum + " - " + sumOfSquaredNumbers + " = " + difference);					
	}
}