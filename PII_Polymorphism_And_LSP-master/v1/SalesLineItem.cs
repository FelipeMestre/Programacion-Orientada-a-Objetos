//-------------------------------------------------------------------------------
// <copyright file="SalesLineItem.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public class SalesLineItem
    {
        public SalesLineItem(double quantity, ProductSpecification product)
        {
            this.Quantity = quantity;
            this.Product = product;
        }

        public double Quantity { get; set; }

        public ProductSpecification Product { get; set; }

        public double SubTotal
        {
            get
            {
                return this.Quantity * this.Product.Price;
            }
        }

        public string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Product.Description}' a ${this.Product.Price}\n";
        }
    }
}