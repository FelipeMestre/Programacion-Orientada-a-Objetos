//-----------------------------------------------------------------------------
// <copyright file="FilePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-----------------------------------------------------------------------------
using System;
using System.IO;

namespace Polymorphism
{
    public class FilePrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            File.WriteAllText("Ticket.txt", sale.GetTextToPrint());
        }
    }
}