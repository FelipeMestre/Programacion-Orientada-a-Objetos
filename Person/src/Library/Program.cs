using System;
using System.Linq;

namespace Persona
{
    public class Person
    {
        public Person(string name, string id )
        {
            this.name = name;
            int valor;
            if ((Int32.TryParse(id,out valor)))
            {
                this.id = id;
            }
            else
            {
                this.id = "";
            }
        }
        public string name {get;set;}
        public string id {get;set;}        

        public void IntroduceYourself()
        {
            Console.WriteLine("Hola, soy: "+this.name+": Mi id es: " + this.id);
        }
        public bool validarFormatoCI(string ci, out string errorMsg)
        {
            errorMsg = "";

            long verificadorFormato;

            //Validar largo
            if (ci.Length == 8 && long.TryParse(ci, out verificadorFormato))
            {
                char[] vectorStrCI = ci.ToCharArray();
                var vectorCI = vectorStrCI.Select(c => int.Parse(c.ToString())).ToArray();
                var vectorReferencia = "2987634".ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

                var verificadorIngresado = vectorCI[7];

                //Calcular número verificador
                int numeroVerificadorRaw = 0;

                for (int i = 0; i < vectorReferencia.Length; i++)
                {
                    numeroVerificadorRaw = numeroVerificadorRaw + (vectorCI[i] * vectorReferencia[i]);
                }

                int verificadorCalculado = 10 - (numeroVerificadorRaw % 10);

                if(verificadorCalculado != verificadorIngresado)
                {
                    errorMsg = "Número verificador ingresado inválido";
                    Console.WriteLine(errorMsg);
                    return false;
                }
            }
            else
            {
                errorMsg = "Formato de cédula de identidad inválido";
                Console.WriteLine(errorMsg);
                return false;
            }

            return true;
        }
        
    }

    class Program
    {
        public static void Main()
        {
            Person Felipe = new Person("Felipe Mestre","49209164");
        }
    }
}