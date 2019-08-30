using System.Collections.Generic;
namespace Program 
{
        class DVD : Obra
        {
                public DVD(string nombre, string genero, List <string> actores) : base(nombre, genero)
                {
                        this.Actores = actores;
                }

                public List<string> Actores { get; }
        }
}