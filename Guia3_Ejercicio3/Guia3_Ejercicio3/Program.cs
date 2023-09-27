using System;
using System.Linq;

public class demo
{
    public static void Main()
    {
        double[] numbers  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        double exponente = 2;
        double resultado = 0;

        foreach (double number in numbers) 
        {
            double potencia = Math.Pow(number, exponente);
            resultado += potencia;
        }

        Console.WriteLine("La acumulacion de los cuadrados de los primeros 20 dígitos es = " + resultado);

    }
}