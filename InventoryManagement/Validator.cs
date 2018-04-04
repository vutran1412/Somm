using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InventoryManagement
{
    // Validator class to validate user input
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        // Checks for any empty fields
        public static bool IsPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag + " is a required field.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }
        // Checks for an integer
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer. ", Title);
                textBox.Focus();
                return false;
            }
        }
        // Check to see if its within range
        public static bool IsWithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between "
                    + min + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        // Checks if is a decimal
        public static bool IsDecimal(TextBox textbox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textbox.Tag + " must be a decimal value.", Title);
                textbox.Focus();
                return false;
            }
        }
        

        
    }
}
