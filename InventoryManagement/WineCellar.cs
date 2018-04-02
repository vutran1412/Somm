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
    public partial class frmWineCellar : Form
    {
        public frmWineCellar()
        {
            InitializeComponent();
        }

        private List<Product> products = new List<Product>();


        private void frmWineCellar_Load(object sender, EventArgs e)
        {
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstInventoryBox.Items.Clear();
            foreach (Product p in products)
            {
                lstInventoryBox.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddNewProduct newProductForm = new frmAddNewProduct();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                products.Add(product);
                FillProductListBox();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int i = lstInventoryBox.SelectedIndex;
            if (i != -1)
            {
                Product product = products[i];
                string message = "Are you sure you want to delete " + product.ProductName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNoCancel);
                if (button == DialogResult.Yes)
                {
                    products.Remove(product);
                    FillProductListBox();
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
