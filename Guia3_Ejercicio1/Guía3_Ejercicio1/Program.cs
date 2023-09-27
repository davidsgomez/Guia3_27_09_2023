using System;
using System.Linq;

public class demo
{
    public static void Main()
    {

        double PI = Math.PI;
        double truncate = Math.Truncate(PI);

        Console.WriteLine("The trucate value of " + truncate);
        Console.WriteLine("Redondeado hacia arriba = " + Math.Ceiling(PI));
        Console.WriteLine("Redondeado hacia abajo = " + Math.Floor(PI));

    }
}
