using System;

namespace Program
{
    abstract class Obra
    {
        public string nombre {get;}
        public string genero{get;}
        public Obra(string nombre, string genero)
        {
            this.nombre = nombre;
            this.genero = genero;
        }
    }
}
