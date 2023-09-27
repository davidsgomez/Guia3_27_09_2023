using System;

public class demo
{
    public static void Main()
    {
        int a, b, c;
        double x1 = 0, x2 = 0;

        Console.WriteLine("Escribe el valor A: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el valor B: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el valor C: ");
        c = int.Parse(Console.ReadLine());

        double discriminante = Math.Pow(b, 2) - (4 * a * c);

        if (discriminante < 0)
        {
            Console.WriteLine("La ecuación no tiene soluciones reales porque el discriminante es negativo.");
        }
        else
        {
            x1 = ((-1 * b) + Math.Sqrt(discriminante)) / (2 * a);
            x2 = ((-1 * b) - Math.Sqrt(discriminante)) / (2 * a);

            Console.Write("El valor de x1 es: {0}", x1);
            Console.Write("\nEl valor de x2 es: {0}", x2);
        }
    }
}
