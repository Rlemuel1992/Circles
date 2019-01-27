using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndCirc
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please input a radius");
			double.TryParse(Console.ReadLine(), out double radius);
			bool b = Validator.IsValid(radius);
			Circle c = new Circle(radius);
			
		
			Console.WriteLine("So your circumference will be " + c.CalculateFormattedCircumference() +
							  ".\nAnd your area will be " + c.CalculateFormattedArea());

			Console.WriteLine("Would you like to do another? y/n");
			bool runAgain = true;
			while (runAgain == true)
			{
				string answer = Console.ReadLine().ToLower();
				if (answer == "y")
				{
					Main();
				}

				else if (answer == "n")
				{
					Console.WriteLine("Alright, goodbye!");
					Environment.Exit(1);
				}
				else
					Console.WriteLine("I didn't understand that, please type again, y/n");
				runAgain = true;
			}
		}
	}
}
