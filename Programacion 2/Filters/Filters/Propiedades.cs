using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel
{
        public class Propiedades
        {
                public Propiedades(int[,] matriz, int divisor, int complemento)
                {
                        this.Matriz = matriz;
                        this.Divisor = divisor;
                        this.Complemento = complemento;
                }

                public int[,] Matriz { get; }
                public int Divisor { get; }
                public int Complemento { get; }
        }
}