using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopForms
{
    public partial class CoffeShopForm : Form
    {
        string customerName = "";
        string contactNumber ;
        string address;
        int quantity =0;
        string order ;
        int totalPrice = 0;

        public CoffeShopForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customerName = CustomerNameTextBox.Text;
            contactNumber = ContactNumberTextBox.Text;
            address = addressTextBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);
            order = orderComboBox.Text;
            totalPrice = 0;
            if ( order == "")
            {
                MessageBox.Show("Select a Product");

            }
            else if ( order == "Black")
            {
                Int32 blackPriceRate = 120;
                totalPrice = quantity * blackPriceRate;
            }
            else if ( order == "Cold")
            {
                Int32 coldPriceRate = 100;
                totalPrice = quantity * coldPriceRate;
            }
            else if ( order == "Hot")
            {
                Int32 hotPriceRate = 90;
                totalPrice = quantity * hotPriceRate;

            }
            else
            {
                Int32 regularPriceRate = 80;
                totalPrice = quantity * regularPriceRate;
            }
            richTextBox.Text = "Coffee Purchase Information:\n\nCustomer Name: " + customerName +
                "\n Contact Number: " + contactNumber + "\nAddress: " + address +
                 "\nOrder: " + order + "\nQuantity: " + quantity + "\n\nTotal Price: " + totalPrice;

        }


        private void DetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Coffee Purchase Information:\n\nCustomer Name: " + customerName +
                "\n Contact Number: " + contactNumber + "\nAddress: " + address +
                 "\nOrder: " + order + "\nQuantity: " + quantity + "\n\nTotal Price: " + totalPrice);
        }
    }
}
