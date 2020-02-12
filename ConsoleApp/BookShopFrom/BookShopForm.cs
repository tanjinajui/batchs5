using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopFrom
{
    public partial class BookShopForm : Form
    {
        string customerName = "";
        string contactNumber;
        string address;
        int quantity = 0;
        string order;
        int totalPrice = 0;

        public BookShopForm()
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
            if (order == "")
            {
                MessageBox.Show("Select a Product");

            }
            else if (order == "CSE")
            {
                Int32 CSEBookPriceRate = 150;
                totalPrice = quantity * CSEBookPriceRate;
            }
            else if (order == "BCE")
            {
                Int32 BCEBookPriceRate = 120;
                totalPrice = quantity * BCEBookPriceRate;
            }
            else if (order == "BME")
            {
                Int32 BMEBookPriceRate = 110;
                totalPrice = quantity * BMEBookPriceRate;

            }
            else
            {
                Int32 regularBookPriceRate = 100;
                totalPrice = quantity * regularBookPriceRate;
            }
            richTextBox.Text = "Book Shop Information:\n\nCustomer Name: " + customerName +
                "\n Contact Number: " + contactNumber + "\nAddress: " + address +
                 "\nOrder: " + order + "\nQuantity: " + quantity + "\n\nTotal Price: " + totalPrice;
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Shop Information:\n\nCustomer Name: " + customerName +
               "\n Contact Number: " + contactNumber + "\nAddress: " + address +
                "\nOrder: " + order + "\nQuantity: " + quantity + "\n\nTotal Price: " + totalPrice);
        }
    }
}
