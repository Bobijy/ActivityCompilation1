using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    private Time(int totalMinutes)
    {
        this.minutes = totalMinutes;
    }

    public static implicit operator Time(int totalMinutes)
    {
        return new Time(totalMinutes);
    }

    public static explicit operator int(Time t)
    {
        return t.minutes;
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
        Time t2 = 165; // Implicit conversion from int to Time

        Console.WriteLine(t1);
        Console.WriteLine(t2);

        int minutesSinceMidnight = (int)t1; // Explicit conversion from Time to int
        Console.WriteLine($"t1 minutes since midnight:  {minutesSinceMidnight}");
    }
}
