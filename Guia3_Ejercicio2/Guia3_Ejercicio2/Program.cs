using System;
using System.Linq;

public class demo
{
    public static void Main()
    {

        double euler = Math.E;
        double redonddecimal = Math.Round(euler, 10);

        Console.WriteLine("Valor de la constante Euler = " + euler);
        Console.WriteLine("Redondeado solo 10 posiciones = " + redonddecimal);

    }
}