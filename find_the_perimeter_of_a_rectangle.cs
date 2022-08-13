/* LINK: https://edabit.com/challenge/5JzZhNdpRkDKsWwFW

Find the Perimeter of a Rectangle

Create a function that takes length and width and finds the perimeter of a rectangle.
Examples

FindPerimeter(6, 7) ➞ 26

FindPerimeter(20, 10) ➞ 60

FindPerimeter(2, 9) ➞ 22

Notes

    Don't forget to return the result.
    If you're stuck, find help in the Resources tab.
    If you're really stuck, find solutions in the Solutions tab. */

public class Program
{
    // Equation: Rectangle Perimeter = 2(length + width)
    // A lambda expression can be used to represent the perimeter calculation.
    public static int FindPerimeter(int length, int width) => 2 * (length + width);
}
