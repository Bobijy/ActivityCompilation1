using System;
using System.ComponentModel;

public struct Time
{
    private readonly int minutes;
    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public override String ToString()
    {
        return minutes.ToString();
    }
}

public class  Program
{
    
    static void Main(string[] args)
    {
        Time type1 = new Time (1, 30);
        Time type2 = new Time(2, 30);

        Console.WriteLine(type1);
        Console.WriteLine(type2);
        Console.WriteLine($"{type1} {type2}");
    }
}