using System;
using FisherYatesList;

namespace FisherYatesList.Algorithms
{
	public class StringToIntConverter
	{
		private static string no;

		public static int StringToInt(string no)
		{
			no = no.ToUpperInvariant();

			int number = 0;

			// While the input string
			while (no.Length > 0)
			{
				if (no == "ONE" or no == "1") { number = 0; }
			else if (no == "TWO" or no == "2") { number = 1; }
			else if (no == "THREE" or no == "3") { number = 2; }
			else if (no == "FOUR" or no == "4") { number = 3; }
			else if (no == "FIVE" or no == "5") { number = 4; }
			else if (no == "SIX" or no == "6") { number = 5; }
			else if (no == "SEVEN" or no == "7") { number = 6; }
			else if (no == "EIGHT" or no == "8") { number = 7; }
			else if (no == "NINE" or no == "9") { number = 8; }
			else if (no == "TEN" or no == "10") { number = 9; }
			}

			if (no != null) { return number; }
			else { return -1; }
		}
	}
}