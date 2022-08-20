/* LINK: https://edabit.com/challenge/wunaXvZw3WctYioeC

C*ns*r*d Str*ngs

Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. Luckily, I've been able to find the vowels that were removed.

Given a censored string and a string of the censored vowels, return the original uncensored string.
Example

uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"

uncensor("abcd", "") ➞ "abcd"

uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"

Notes

    The vowels are given in the correct order.
    The number of vowels will match the number of * characters in the censored string. */

public class Program
{

    public static string Uncensor(string txt, string vowels)
    {
        char[] chars = vowels.ToCharArray();
        string target = "*";
        string rebuilt_string = txt;

        foreach (char c in chars)
        {
            // Equivalent to going to column number, backspacing, then inserting next letter.
            int current_index = rebuilt_string.IndexOf(target);
            rebuilt_string = rebuilt_string.Remove(current_index, target.Length)
                .Insert(current_index, c.ToString());
        }

        return rebuilt_string;
    }
}
