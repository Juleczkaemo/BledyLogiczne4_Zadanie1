using System;

class Program
{
    static void Main()
    {
        int a = 15, b = 8, c = 12;
        int min = a;

        if (b < min) 
        {
            min = b;
        }

        if (c < min) //błąd polegał na tym, że wartość większa była przypisywana do zmiennej min a nie wartość mniejsza.
        {
            min = c;
        }

        Console.WriteLine($"Minimum: {min}");
    }
}