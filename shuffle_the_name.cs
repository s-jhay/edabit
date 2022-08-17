/* LINK: https://edabit.com/challenge/c4W4BNymgCC5WkfHp

Shuffle the Name

Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
Examples

NameShuffle("Donald Trump") ➞ "Trump Donald"

NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"

NameShuffle("Seymour Butts") ➞ "Butts Seymour"

Notes

    There will be exactly one space between the first and last name.
    If you get stuck on a challenge, find help in the Resources tab.
    If you're really stuck, unlock solutions in the Solutions tab. */
public class Program
{
    public static string NameShuffle(string str)
    {
        string[] names = str.Split(' ');

        return $"{names[1]} {names[0]}";
    }
}
