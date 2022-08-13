/* LINK: https://edabit.com/challenge/JYEufqRvkusjr5R58

Find the Bomb

Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
Examples

Bomb("There is a bomb.") ➞ "Duck!!!"

Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"

Bomb("This goes boom!!!") ➞ "There is no bomb, relax."

Notes

"bomb" may appear in different cases (i.e. uppercase, lowercase, mixed). */

public class Program
{
	public static string Bomb(string sus_string)
	{
		string returnString = string.Empty;

		// Use .ToLower() and .Contains methods to find the target substring.
		if (sus_string.ToLower().Contains("bomb"))
        {
			returnString = "Duck!!!";

		}
		else
        {
			returnString = "There is no bomb, relax.";

		}

		return returnString;
	}
}
