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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            string numberLabel = "";
            string points = "";
            string money = "";
            StreamReader detailsReader = File.OpenText(applicationPath + "userInfo.txt");
            string lineOfText = detailsReader.ReadLine();
            while (lineOfText != null && found == false)
            {
                string[] individual = lineOfText.Split(',');
                if (email == individual[1].Trim())
                {
                    numberLabel = individual[3];
                    points = individual[4];
                    money = individual[5];
                    found = true;
                }
                else
                {
                    lineOfText = detailsReader.ReadLine();
                }
            }
            genNumberLabel.Text = numberLabel;
            pointsGetLabel.Text = points;
            moneyGetLabel.Text = "£" + money;
            detailsReader.Close();
        }

        private void voucherButton_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (pointsGetLabel.Text != "-") {
                if (Convert.ToInt16(pointsGetLabel.Text) >= 500) {
                    int currentPoints = Convert.ToInt16(pointsGetLabel.Text);
                    int money = Convert.ToInt16(moneyGetLabel);
                    money = money + 5;
                    currentPoints = currentPoints - 500;
                    pointsGetLabel.Text = Convert.ToString(currentPoints);
                    moneyGetLabel.Text = Convert.ToString(money);
                    StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
                    string email = customerReader.ReadLine().Trim();
                }
            }
        }
    }
}
