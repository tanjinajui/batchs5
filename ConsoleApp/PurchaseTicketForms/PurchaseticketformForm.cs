using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketForms
{
    public partial class PurchaseticketformForm : Form
    {
        private int numberOfTickets = 0;
        private double unitPrice = 10;
        private string customerName = "";
        private int contactNumber;
        private string address = "";
        private double totalPrice = 0;

        public PurchaseticketformForm()
        {
            InitializeComponent();
        }

        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            numberOfTickets = Convert.ToInt32(numberOfTicketTextBox.Text);
            customerName = CustomerNameTextBox.Text;
            contactNumber = Convert.ToInt32(ContactNumberTextBox.Text);
            address = addressTextBox.Text;
            totalPrice = unitPrice * numberOfTickets;
            MessageBox.Show("Customer Name: " + customerName + ", Contact Number: " + contactNumber + ", Address: " + address + ", Please Pay " + totalPrice + " Taka to Purchase " + numberOfTickets + " Ticket (s");
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " + customerName + "\nContact Number: " + contactNumber + "\nAddress: " + address + "\nUnit Price: " + unitPrice + "\n Total Price: " + totalPrice);
        }
    }
}
