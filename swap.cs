using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a1, b1;
        int temp;
        Console.WriteLine("enter the a1");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value b1");
        b1 = Convert.ToInt32(Console.ReadLine());
        temp = a1;
        a1 = b1;

        Console.WriteLine("After swap a={0},b={1}", a, b);




    }
}