// See https://aka.ms/new-console-template for more information

// Ask the user to enter the number of items wanted in the array
Console.WriteLine("Enter the total number of your list items: ");
string arrStr = Console.ReadLine();

// Convert to number

int arrNum = StringToInt(arrStr);

//Debugging: Write the array number
Console.WriteLine(arrNum);