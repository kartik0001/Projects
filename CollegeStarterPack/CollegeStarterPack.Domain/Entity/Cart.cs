﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStarterPack.Domain.Entity
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.ProductId == product.ProductId)
       .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(
                    new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(p => p.Product.ProductId == product.ProductId);

        }
        //return the total product price
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(p => p.Product.Price * p.Quantity);
        }

        public IEnumerable<CartLine> Lines
        {

            get { return lineCollection; }

        }
        //clear the cart
        public void Clear()
        {
            lineCollection.Clear();
        }
    }
}

