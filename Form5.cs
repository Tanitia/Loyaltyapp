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

        private void QRBox_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
            string email = customerReader.ReadLine().Trim();
            customerReader.Close();
            bool found = false;
            string usersName = "";
            string numberLabel = "";
            string totalCredit = "";
            string totalPoints = "";
            string totalVouchers = "";
            StreamReader detailsReader = File.OpenText(applicationPath + "userInfo.txt");
            string lineOfText = detailsReader.ReadLine();
            while (lineOfText != null && found == false)
            {
                string[] individual = lineOfText.Split(',');
                if (email == individual[1].Trim())
                {
                    usersName = individual[0];
                    numberLabel = individual[3];
                    totalPoints = individual[6];
                    totalCredit = individual[7];
                    totalVouchers = individual[8]; 
                    found = true;
                }
                else
                {
                    lineOfText = detailsReader.ReadLine();
                }
            }
            welcomeNameLabel.Text = "Hi   " + usersName;
            genNumberLabel.Text = numberLabel;
            vouchersLabel.Text = totalVouchers + " vouchers";
            cashbackLabel.Text = totalCredit + " cashback";
            earnedLabel.Text = "And earned " + totalPoints + " points! Wow!";
            detailsReader.Close();
        }
    }
    }
