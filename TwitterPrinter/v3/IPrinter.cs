//-------------------------------------------------------------------------
// <copyright file="Printer.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public interface IPrinter
    {
         void PrintTicket(Sale sale);
    }
}