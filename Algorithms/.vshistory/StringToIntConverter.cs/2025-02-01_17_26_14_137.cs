using System;

public class StringToIntConverter
{
	private static string no;

	public static int StringToInt(string no)
	{
		no = no.ToUpperInvariant();
		
		int number = 0;

		while (no.Length > 0)
		{
			if (no == "ONE") { number = 0; }
			else if (no == "TWO") { number = 1; }
			else if (no == "THREE") { number = 2; }
			else if (no == "FOUR") { number = 3; }
			else if (no == "FIVE") { number = 4; }
			else if (no == "SIX") { number = 5; }
			else if (no == "SEVEN") { number = 6; }
			else if (no == "EIGHT") { number = 7; }
			else if (no == "NINE") { number = 8; }
			else if (no == "TEN") { number = 9; }
		}

		if (no != null) { return number; }
		else {return -1;}
	}
}