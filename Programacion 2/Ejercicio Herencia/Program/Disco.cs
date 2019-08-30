using System.Collections.Generic;
using System;
namespace Program
{
        class Cd : Obra
        {
                public string artista {get;}
                public List<string> Canciones { get; }
                public Int32 año {get;}
                public Cd(string nombre, string genero, string artista, List<string> canciones, Int32 año) : base(nombre, genero)
                {
                    this.artista = artista;
                    this.Canciones = canciones;
                    this.año = año;   
                }
        }
}