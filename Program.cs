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

			

		}
	}
}
