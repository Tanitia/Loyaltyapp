using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Loyaltyapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != null && emailTextbox.Text != null && passwordTextbox.Text != null) {
                string applicationPath = Directory.GetCurrentDirectory() + "\\";
                // Creates a file on the HDD at the applicationPath location called, "MyFile.txt"
                StreamWriter mOutputStream = File.CreateText(applicationPath + "userInfo.txt");
                mOutputStream.WriteLine(nameTextbox.Text, ",", emailTextbox.Text, ",", passwordTextbox.Text);
            }
        }

        private void signinLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppLogin signUpForm = new AppLogin();
            signUpForm.ShowDialog();
            this.Close();
        }
    }
}
