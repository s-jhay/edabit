/* LINK: https://edabit.com/challenge/kMWmiNJM4szSv7dLd

Find the Smallest and Biggest Numbers

Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
Examples

FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]

FindMinMax([2334454, 5]) ➞ [5, 2334454]

FindMinMax([1]) ➞ [1, 1]

Notes

All test arrays will have at least one element and are valid. */

using System;
using System.Linq;

public class Program
{
    public static double[] FindMinMax(double[] values)
    {
        // LINQ makes this easier including Min() and Max() methods.
        double min = values.Min();
        double max = values.Max();

        double[] minAndMax = { min, max };

        return minAndMax;
    }
}
