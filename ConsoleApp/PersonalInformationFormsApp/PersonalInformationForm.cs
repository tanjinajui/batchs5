using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationFormsApp
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        

        private void ShowAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + firstNameTextBox.Text + ", Last Name: " + lastNameTextBox.Text + ", Father's Name: " + fathersNameTextBox.Text +
                ",  Mother's Name: " + mothersNameTextBox.Text + ", Address: " + address.Text);
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("First Name: " + firstNameTextBox.Text + ", Last Name: " + lastNameTextBox.Text );
        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Father's Name: " + fathersNameTextBox.Text + ",  Mother's Name: " + mothersNameTextBox.Text);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address: " + address.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + firstNameTextBox.Text + ", Last Name: " + lastNameTextBox.Text + ", Father's Name: " + fathersNameTextBox.Text +
                ",  Mother's Name: " + mothersNameTextBox.Text + ", Address: " + address.Text);
            richTextBox.Text= ("First Name: " + firstNameTextBox.Text + ", Last Name: " + lastNameTextBox.Text + ", Father's Name: " + fathersNameTextBox.Text +
                ",  Mother's Name: " + mothersNameTextBox.Text + ", Address: " + addressTextBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int add = firstNumber + secondNumber;
            resultTextBox.Text = add.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sub = firstNumber - secondNumber;
            resultTextBox.Text = sub.ToString();
        }

        private void MultButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int mult = firstNumber * secondNumber;
            resultTextBox.Text = mult.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {

            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int div = firstNumber / secondNumber;
            resultTextBox.Text = div.ToString();
        }
    }
}
