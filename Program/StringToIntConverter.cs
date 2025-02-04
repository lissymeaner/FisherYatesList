using System;
using FisherYatesList;

namespace FisherYatesList.Algorithms
{
	/// <summary>
	/// Provides utility methods for converting string representations of numbers to integers.
	/// Supports both numeric strings (e.g., "123") and number words (e.g., "One", "TWO", "three").
	/// </summary>
	public class StringToIntConverter
	{
		/// <summary>
		/// Converts a string representation of a number (either numeric or word form) to an integer.
		/// </summary>
		/// <param name="num">The string to convert. Can be a numeric string (e.g., "123") or a number word (e.g., "ONE").</param>
		/// <returns>
		/// The integer representation of the input string. Returns -1 if the input is invalid or cannot be parsed.
		/// </returns>
		/// <example>
		/// <code>
		/// int result = StringToIntConverter.StringToInt("THREE"); // Returns 3
		/// int result = StringToIntConverter.StringToInt("42");    // Returns 42
		/// int result = StringToIntConverter.StringToInt("ABC");   // Returns -1 (invalid input)
		/// </code>
		/// </example>
		public static int StringToInt(string num)
		{
			if (string.IsNullOrWhiteSpace(num))
			{
				return -1; // Indicates invalid input
			}

			int number = 0;

			switch (num.ToUpper())
			{
				case "1": case "ONE": return 1;
				case "2": case "TWO": return 2;
				case "3": case "THREE": return 3;
				case "4": case "FOUR": return 4;
				case "5": case "FIVE": return 5;
				case "6": case "SIX": return 6;
				case "7": case "SEVEN": return 7;
				case "8": case "EIGHT": return 8;
				case "9": case "NINE": return 9;

				// if the number is above 9, then just parse the string,
				// ...or otherwise return -1 to avoid exception.
				default:
					if (Int32.TryParse(num, out number))
					{
						return number;
					}
					return -1; // Indicates valid input
			}
		}
	}
}