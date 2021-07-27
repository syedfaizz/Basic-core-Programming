using System;
public class Example
{
    public static void Main(string[] args)
    {
        int a1, b1, c1;

        Console.WriteLine("enter the a1");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value b1");
        b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the c1");
        c1 = Convert.ToInt32(Console.ReadLine());
        if (a1 > b1 && (b1 > c1))
        {
            Console.WriteLine("a1 is greater" + a1);
        }

        else if (b1 > a1 && (a1 > c1))
        {
            Console.WriteLine("b1 is greater" + b1);
        }

        else
        {
            Console.WriteLine("c1 is greater" + c1);
        }
    }
}
