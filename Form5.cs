using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loyaltyapp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 homeForm = new Form3();
            homeForm.ShowDialog();
            this.Close();
        }
    }
}
