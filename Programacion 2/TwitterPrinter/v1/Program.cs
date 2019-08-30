//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections;

namespace Polymorphism
{
    public class Program
    {
        private static ArrayList productCatalog = new ArrayList();

        public static void Main(string[] args)
        {
            PopulateCatalog();

            Sale sale = new Sale();
            sale.DateTime = DateTime.Now;
            sale.AddLineItem(new SalesLineItem(1, ProductAt(0)));
            sale.AddLineItem(new SalesLineItem(2, ProductAt(1)));
            sale.AddLineItem(new SalesLineItem(3, ProductAt(2)));

            AllInOnePrinter printer = new AllInOnePrinter();
            printer.PrintTicket(sale, Destination.Console);
            printer.PrintTicket(sale, Destination.File);
        }

        private static void PopulateCatalog()
        {
            AddProductToCatalog("Product 1", 100.00);
            AddProductToCatalog("Product 2", 200.00);
            AddProductToCatalog("Product 3", 300.00);
        }

        private static void AddProductToCatalog(string description, double price)
        {
            productCatalog.Add(new ProductSpecification(description, price));
        }

        private static ProductSpecification ProductAt(int index)
        {
            return productCatalog[index] as ProductSpecification;
        }
    }
}
