namespace Program
{
        abstract class Persona
        {
                public string apellido {get;}
                public string nombre {get;}
                public Persona(string nombre, string apellido)
                {
                        this.nombre = nombre;
                        this.apellido = apellido;
                }
        }
}