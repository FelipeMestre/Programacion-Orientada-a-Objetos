//--------------------------------------------------------------------------------
// <copyright file="ConsolePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;
using System.IO;

namespace Polymorphism
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            Console.WriteLine(sale.GetTextToPrint());
        }
    }
}