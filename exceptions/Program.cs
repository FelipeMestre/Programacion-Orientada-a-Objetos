using System;
using System.Collections;

namespace exceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            int y = 0;
            ArrayList x = new ArrayList();
            x.Add(5);
            x.Add(3);
            x.Add(25);
            x.Add(100);
            x.Add("");
            int count = x.Count;
            System.Console.WriteLine(count);
            for (int i = 0; i <= (count-1); i++ )
            {
                try
                {    
                    int a = Convert.ToInt32(x[(i+1)]);
                    //System.Console.WriteLine("imasuno: "+(i+1));
                    //System.Console.WriteLine("a: "+a);
                    //System.Console.WriteLine("y: "+y);
                    System.Console.WriteLine(a/y);
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Error de valor");
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("Error de indice");
                }
                catch (DivideByZeroException)
                {
                    System.Console.WriteLine("Division Entre Cero");
                    y = 2;
                }
                finally
                {
                    System.Console.WriteLine("Fin interaccion  " + (i+1) );
                }
            }
        }  
    }
}

