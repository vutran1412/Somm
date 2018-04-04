using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    // The Product class, this is all the information that the app will store for now
    // Version 2.0, might include a parcount stored internally within the class
    public class Product
    {
        // Class properties
        private string productName;
        private int productYear;
        private decimal productPrice;
        private int productQuantity;
       
        // Empty constructor to allow for a null instatiation later
        public Product() { }

        // OverLoaded constructor that will store the data
        public Product(string productName, int productYear, decimal productPrice, int productQuantity)
        {
            this.ProductName = productName;
            this.ProductYear = productYear;
            this.ProductPrice = productPrice;
            this.ProductQuantity = productQuantity;
            
            

        }

        // Getters and Setters
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

        
    }

    
}
