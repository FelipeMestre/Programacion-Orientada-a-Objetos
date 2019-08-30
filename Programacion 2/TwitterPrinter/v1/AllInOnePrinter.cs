//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Polymorphism
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintTicket(Sale sale, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(sale.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Ticket.txt", sale.GetTextToPrint());
            }
        }
    }
}