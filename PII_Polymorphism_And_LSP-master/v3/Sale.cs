//-------------------------------------------------------------------------
// <copyright file="Sale.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections;

namespace Polymorphism
{
    public class Sale
    {
        private ArrayList lineItems = new ArrayList();

        public DateTime DateTime { get; set; }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (SalesLineItem item in this.lineItems)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        public void AddLineItem(SalesLineItem item)
        {
            this.lineItems.Add(item);
        }

        public void RemoveLineItem(SalesLineItem item)
        {
            this.lineItems.Remove(item);
        }

        public string GetTextToPrint()
        {
            string result = $"Fecha: {this.DateTime}\n";
            foreach (SalesLineItem item in this.lineItems)
            {
                result = result + item.GetTextToPrint();
            }

            result = result + $"Total: ${this.Total}";
            return result;
        }
    }
}