using System;
namespace Program
{
        class Program
    {
            static void Factorial(int n)
            {
                int acumulador = 1;
                for (int i = 1; i <= n; i++)
                {
                    acumulador = acumulador * i;
                    System.Console.WriteLine(acumulador);
                }
                return acumulador;
            }
    }
}