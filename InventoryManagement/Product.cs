using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {
        private string productName;
        private int productYear;
        private decimal productPrice;
        private int productQuantity;
       

        public Product() { }

        public Product(string productName, int productYear, decimal productPrice, int productQuantity)
        {
            this.ProductName = productName;
            this.ProductYear = productYear;
            this.ProductPrice = productPrice;
            this.ProductQuantity = productQuantity;
            
            

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

        public int ProductYear
        {
            get
            {
                return productYear;
            }
            set
            {
                productYear = value;
            }
        }

        public string GetDisplayText(string sep)
        {
            return productName.ToString() + sep + productYear.ToString() + sep + productPrice.ToString("c") 
                + sep + productQuantity.ToString() + " btl";
                
        }
    }

    
}
