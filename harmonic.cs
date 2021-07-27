using System;

class GFG
{

    // Function to return sum of 
    // 1/1 + 1/2 + 1/3 + ..+ 1/n 
    static float sum(int n)
    {
        double i, s = 0.0;

        for (i = 1; i <= n; i++)
            s = s + 1 / i;

        return (float)s;

    public static void Main()
    {
        int n = 5;

        Console.WriteLine("Sum is "
                           + sum(n));

    }
