using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loyaltyapp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 signUpForm = new Form2();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 shopForm = new Form4();
            shopForm.ShowDialog();
            this.Close();
        }

        private void pastButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 pastForm = new Form5();
            pastForm.ShowDialog();
            this.Close();
        }
    }
}
