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

        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(txtProduct.Text, Convert.ToInt32(txtYear.Text), Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtQuantity.Text));
                this.Close();

                
            }
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
