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

            listViewWine.View = View.Details;
            listViewWine.FullRowSelect = true;

            listViewWine.Columns.Add("Wine", 150);
            listViewWine.Columns.Add("Year", 50);
            listViewWine.Columns.Add("Price", 100);
            listViewWine.Columns.Add("Quantity", 150);
             
        }

        private void add(String wine, String year, String price, String quantity)
        {
            String[] row = { wine, year, price, quantity };

            ListViewItem item = new ListViewItem(row);

            listViewWine.Items.Add(item);
        }

        private List<Product> products = new List<Product>();


        private void frmWineCellar_Load(object sender, EventArgs e)
        {
            
        }


        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddNewProduct newProductForm = new frmAddNewProduct();
            Product product = newProductForm.GetNewProduct();

            add(product.ProductName, product.ProductYear.ToString(), product.ProductPrice.ToString("c"), product.ProductQuantity.ToString());
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            int editRow = listViewWine.SelectedIndices[0];

            if (editRow == -1)
            {
                MessageBox.Show("Please select a product to edit");
            } else
            {
                String input = Microsoft.VisualBasic.Interaction.InputBox("Update Quantity", "Update", "Quantity", 0, 0);
                listViewWine.SelectedItems[0].SubItems[3].Text = input.ToString();
            }
        }

        private void delete()
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                listViewWine.Items.RemoveAt(listViewWine.SelectedIndices[0]);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            delete();
           
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
