﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {
        private string productName;
        private int productQuantity;
        private decimal productPrice;
        private DateTime productRecieved = DateTime.Now;

        public Product() { }

        public Product(string productName, int productquantity, decimal productPrice, 
            DateTime productRecieved)
        {

        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public int ProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }

        public DateTime ProductRecieved
        {
            get
            {
                return productRecieved;
            }
            set
            {
                productRecieved = value;
            }
        }

        public string GetDisplayText(string sep)
        {
            return productName.ToString() + sep + productQuantity.ToString()
                + sep + productPrice.ToString("c") 
                + sep + productRecieved.ToString("{0:d}");
        }
    }

    
}
