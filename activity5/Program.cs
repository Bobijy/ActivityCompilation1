using System;
using System.Runtime.InteropServices;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public override String ToString()
    {
        return $"{minutes / 60}:{minutes % 60}";
    } 
    public static Time operator +(Time t1, Time t2)
    {
        return new Time(0, t1.minutes + t2.minutes);
    }
    public static Time operator -(Time t1, Time t2)
    {
        return new Time(0, t1.minutes - t2.minutes);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time(1, 30);
        Time t2 = new Time(2, 45);

        Console.WriteLine("Original Times: ");
        Console.WriteLine(t1);
        Console.WriteLine(t2 + "\n");


        Console.WriteLine("After Addition: "); 
        Time timeAddition= t1 + t2;
        Console.WriteLine(timeAddition);

        Console.WriteLine("\nAfter Subtraction: ");
        Time timeSubtraction = t2 - t1;
        Console.WriteLine(timeSubtraction);
    }
}
