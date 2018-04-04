using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class frmAddNewProduct : Form
    {
        public frmAddNewProduct()
        {
            InitializeComponent();
        }

        // Instantiates a product object
        private Product product = null;

        // Method that returns the product data to the WineCellar Form
        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product; 
        }

        // Sets up the save button
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(txtProduct.Text, Convert.ToInt32(txtYear.Text), Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtQuantity.Text));
                this.Close();

                
            }
        }
        // Method to validate data
        private bool IsValidData()
        {
            return Validator.IsPresent(txtProduct) &&
                Validator.IsPresent(txtYear) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsPresent(txtQuantity) &&
                Validator.IsInt32(txtYear) &&
                Validator.IsWithinRange(txtYear, 1000, 2018) &&
                Validator.IsInt32(txtQuantity) &&
                Validator.IsWithinRange(txtQuantity, 1, 100) &&
                Validator.IsDecimal(txtPrice);
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            product = new Product();
            this.DialogResult = DialogResult.OK;
        }
    }
}
