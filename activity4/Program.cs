using System;

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
}

public class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time(1, 30);
        Time t2 = new Time(2, 45);

        Console.WriteLine(t1);
        Console.WriteLine(t2);

    }
}