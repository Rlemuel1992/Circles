using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndCirc
{
	class Circle
	{

		private double radius;
		

		public Circle(double radius)
		{
			this.radius = radius;
		}

		public double CalculateCircumference()
		{
			double circumference = 2 * Math.PI * radius;
			return circumference;
		}
		public string CalculateFormattedCircumference()
		{
			
			return FormatNumber(CalculateCircumference()); 
		}

		public double CalculateArea()
		{
			double area = Math.PI * radius * radius;
			return area;
		}

		public string CalculateFormattedArea()
		{
			return FormatNumber(CalculateArea());
		}

		private string FormatNumber(double x)
		{
			return Math.Round(x, 2).ToString();
		
		}

	


















	}
}
