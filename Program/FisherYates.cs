using System;
using FisherYatesList;

namespace FisherYatesList.Algorithms
{
	/// <summary>
	/// Provides the method for shuffling arrays using the Fisher-Yates algorithm.
	/// This algorithm ensures an unbiased shuffle with O(n) time complexity.
	/// </summary>
	public class FisherYates
	{
		private static readonly Random _random = new Random();

		/// <summary>
		/// Generates a random index within the specified range.
		/// </summary>
		/// <param name="number">The upper bound for the random index (exclusive).</param>
		/// <returns>
		/// A random integer between 0 (inclusive) and the specified number (exclusive).
		/// </returns>
		/// <example>
		/// <code>
		/// int index = FisherYates.GetRandomIndex(10); // Returns a random number between 0 and 9
		/// </code>
		/// </example>
		public static int GetRandomIndex(int number) { return _random.Next(number); }

		// Shuffles a list using the Fisher-Yates algorithm.
		public static string[] Shuffle(string[] theList)
		{
			if (theList == null || theList.Length <= 1)
			{
				return theList; // Why shuffle?
			}

			// Create a copy of the input list to avoid modifying the original list.
			int length = theList.Length;
			string[] newList = new string[length];

			int rno = 0;

			Array.Copy(theList, newList, length);

			// Iterate through the list backward, starting from the last element.
			for (int i = length - 1; i > 0; i--)
			{
				//string current_item = newList[i];

				// Generates a random number for the swap.
				rno = GetRandomIndex(i);

				// Stores the temporary item located at the index specified by the random number (rno).
				string temp = newList[i];

				// Swap the current item with a randomly selected item from the remaining unshuffled portion of the list.
				newList[i] = newList[rno];
				newList[rno] = temp;
			}
			return newList; // Returns the shuffled list.
		}
	}
}