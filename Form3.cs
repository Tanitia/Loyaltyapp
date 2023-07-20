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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        
        private void signoutButton_Click(object sender, EventArgs e)
        {
            //redirects to login
            this.Hide();
            AppLogin signUpForm = new AppLogin();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            //redirects to shop
            this.Hide();
            Form4 shopForm = new Form4();
            shopForm.ShowDialog();
            this.Close();
        }

        private void pastButton_Click(object sender, EventArgs e)
        {
            //navigates to past rewards
            this.Hide();
            Form5 pastForm = new Form5();
            pastForm.ShowDialog();
            this.Close();
        }

        private void QRBox_Click(object sender, EventArgs e)
        {
            //loads in user credentials into censored labels
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
            string email = customerReader.ReadLine();
            customerReader.Close();
            bool found = false;
            string usersName = "";
            string numberLabel = "";
            StreamReader detailsReader = File.OpenText(applicationPath + "userInfo.txt");
            string lineOfText = detailsReader.ReadLine();
            while (lineOfText != null && found == false)
            {
                string[] individual = lineOfText.Split(',');
                if (email == individual[1])
                {
                    usersName = individual[0];
                    numberLabel = individual[3];
                    found = true;
                }
                else {
                    lineOfText = detailsReader.ReadLine();
                }
            }
            welcomeNameLabel.Text = usersName;
            genNumberLabel.Text = numberLabel;
            detailsReader.Close();
        }
    }
}
