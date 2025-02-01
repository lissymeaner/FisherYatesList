using FisherYatesList.Algorithms;
using SIConverter = FisherYatesList.Algorithms.StringToIntConverter;

namespace FisherYatesList
{
	/// <summary>
	/// User interface for execution of the Fisher-Yates shuffle algorithm.
	/// </summary>
	public class UI
	{
		/// <summary>
		/// Handles user interaction for the Fisher-Yates shuffle algorithm.
		/// Prompts the user to input a list of items, specifies the number of shuffles,
		/// and displays the original and shuffled lists.
		/// </summary>
		public static void Run()
		{
			//Initialise all needed variables
			int arrNum;
			int fyFactor;
			string? entry;
			string[] arr;
			string[] newArr;

			// Ask the user to enter the number of items they want in the array
			Console.Write("Enter the number of items in your list: ");
			string? arrStr = Console.ReadLine();

			// Convert the user's input (string) to an integer (number of array items)
			arrNum = SIConverter.StringToInt(arrStr);

			// Check if the user entered a valid number of items (greater than 0)
			if (arrNum > 0)
			{
				arr = new string[arrNum];

				#region Entry
				// Prompt the user to enter each item for the array
				for (int i = 0; i < arrNum; i++)
				{
					Console.Write($"Entry {i}: ");
					entry = Convert.ToString(Console.ReadLine());

					arr[i] = entry;
				};
				#endregion

				#region Shuffle factor
				// Ask the user how many times they want to shuffle the array
				Console.Write("\nHow many times would you like to shuffle the list? ");
				string fyFactorStr = Console.ReadLine();

				// Convert the user's input (string) to an integer (number of shuffles)
				fyFactor = SIConverter.StringToInt(fyFactorStr);
				#endregion

				#region Shuffle output
				int j = 0;

				// Print the original array
				Console.WriteLine("\nOriginal array: ");
				foreach (var item in arr) { Console.Write($" ({j}) \"{item}\";"); j++; }

				#region Passes
				j = 0;

				// Perform the Fisher-Yates shuffle algorithm on the array
				newArr = FisherYates.Shuffle(arr);

				// Display the result of the first shuffle iteration
				Console.WriteLine($"\nIteration {j}: ");
				foreach (var item in newArr) { Console.Write($" ({j}) \"{item}\";"); j++; }

				// Continue shuffling until the desired number of shuffles is reached
				j = 0;
				while (j < fyFactor)
				{
					// Perform additional shuffles
					for (int k = 1; k <= fyFactor - 1; k++)
					{
						newArr = FisherYates.Shuffle(newArr); // Shuffle the array again

						// Display the result of the current shuffle iteration
						Console.WriteLine($"\nIteration {k}: ");
						foreach (var item in newArr) { Console.Write($" ({j}) \"{item}\";"); j++; }

						j = 0;
					}

					Console.WriteLine(" ");

					j = fyFactor; // Exit the while loop after completing the required shuffles
				}
				#endregion
				#endregion
			}
		}
	}
}
