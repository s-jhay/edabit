/* LINK: https://edabit.com/challenge/7nzfry4P3WrrL7t38

ATM PIN Code Validation

ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
Examples

ValidatePIN("1234") ➞ true

ValidatePIN("12345") ➞ false

ValidatePIN("a234") ➞ false

ValidatePIN("") ➞ false

Notes

    Some test cases contain special characters.
    Empty strings must return false. */
using System.Text.RegularExpressions;

public class Program
{
    public static bool ValidatePIN(string pin)
    {
        int new_number;
        bool success = int.TryParse(pin, out new_number);

        // TryParse must return true and string must be 4 or 6 digits long
        if (success && Regex.IsMatch(pin, @"^(\d{4}|\d{6})$"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
