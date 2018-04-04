using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Somm
// Author: Vu Tran
// This is a wine inventory management application

namespace InventoryManagement
{
    public partial class frmWineCellar : Form
    {
        public frmWineCellar()
        {
            InitializeComponent();

            // Learned how to use Listview on 
            // https://www.youtube.com/watch?v=vtzAF42lSYE
            // Sets up the ListView Columns
            listViewWine.View = View.Details;
            listViewWine.FullRowSelect = true;

            listViewWine.Columns.Add("Wine", 150);
            listViewWine.Columns.Add("Year", 50);
            listViewWine.Columns.Add("Price", 100);
            listViewWine.Columns.Add("Quantity", 150);

        }

        

        // Method to add rows of product
        private void add(String wine, String year, String price, String quantity)
        {
            // Create an Array of Strings to store data for the row
            String[] row = { wine, year, price, quantity };

            // Creates a list view Item as row
            ListViewItem item = new ListViewItem(row);

            // Adds the row to the ListView
            listViewWine.Items.Add(item);
        }



        private void frmWineCellar_Load(object sender, EventArgs e)
        {

        }

        // Sets up the add new product button, brings up a form
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            // Instantiate a new form object
            frmAddNewProduct newProductForm = new frmAddNewProduct();
            // Creates a new product object from the new form 
            Product product = newProductForm.GetNewProduct();
            // populate the listview with the product object's properties
            if (product != null)
            {
                add(product.ProductName,
                    product.ProductYear.ToString(),
                    product.ProductPrice.ToString("c"),
                    product.ProductQuantity.ToString());
            }
        }
    

        // Sets up the update product button
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // User must select an existing row to edit
            int editRow;
           
            editRow = listViewWine.SelectedIndices[0];
               
            if (editRow == -1)
            {
                MessageBox.Show("Please select a product to edit");
                return;
            }
            else
            {
                // Update the item
                update();
            }
        }

        // Method that updates the data, brings up a popup box
        private void update()
        {
            // Learned about how to implement a input dialog on 
            // https://stackoverflow.com/questions/7883522/input-dialogs-in-c-sharp
            // I wanted to see if there was a JOptionpane equivalent in C#
            // Unfortunately there isn't one
            // Had to reference VisualBasic's Interaction InputBox
            string productName = listViewWine.SelectedItems[0].ToString();
           String input = Microsoft.VisualBasic.Interaction.InputBox(productName,"Update Quantity", "Quantity", 0, 0);
                listViewWine.SelectedItems[0].SubItems[3].Text = input.ToString();

            
            
                
            
        }
        // Method to delete ListView Item
        private void delete()
        {
            // Brings up a confirmation box if user wants to delete
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                listViewWine.Items.RemoveAt(listViewWine.SelectedIndices[0]);
            }
        }

        // Delete button 
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            delete();
           
        }

        // Exit button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
