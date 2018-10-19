using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Critique el siguiente código en base a SRP y patrón Experto
            //Realice la modificaciones necesaras para que se cumplan ambos patrones
            
            Alfajor a = new Alfajor(10, 8.5);
            Kiosko k = new Kiosko();
            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
