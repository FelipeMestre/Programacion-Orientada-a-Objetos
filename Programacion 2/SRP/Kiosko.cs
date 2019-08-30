using System;

namespace Expert_SRP
{
    public class Kiosko 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = conversor.ConvertirAPesos(dinero, moneda);       //Se podría chequear antes si la moneda es pesos, así saber so llamar o no el método para convertir a dólares
            return pesos >= a.PrecioTotal();                // En lugar de tener a.preciomasa + a.preciodulce. Se optimiza en la clase alfajor
        }
    }
    public class conversor      // Se puede hacer la clase conversor, así la clase kiosko tendría una sola responsabilidad
        {
            public static double ConvertirAPesos( double dinero, string moneda)
            {
            if (moneda == "U$S") //No es necesario llamar un método
            {
                return dinero * 30;
            } 
            else if (moneda == "$") 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
            }
        }
}