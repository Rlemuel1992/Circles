﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CircleAreaAndCirc
{
	class Validator
	{


		public static bool IsValid(double y)
		{

			bool z = true;
			while (z == true)
			{
				if (!(y > 0 || y >= 9))
				{
					Program.Main();
				}
				else
					z = false;
				}
			return true;
		}
	}
}

