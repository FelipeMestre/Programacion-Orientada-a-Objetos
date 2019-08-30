//--------------------------------------------------------------------------------------
// <copyright file="ProductSpecification.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
using System.Collections;

namespace Polymorphism
{
    public class ProductSpecification
    {
        public ProductSpecification(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}