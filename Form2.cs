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
                if (!File.Exists(applicationPath + "userInfo.txt"))
                {
                    StreamWriter myOutputStream = File.CreateText("userInfo.txt");
                    myOutputStream.Close();
                }
                // Creates a file on the HDD at the applicationPath location"
                StreamWriter mOutputStream = File.AppendText(applicationPath + "userInfo.txt");
                mOutputStream.WriteLine(nameTextbox.Text+ ","+ emailTextbox.Text+ ","+ passwordTextbox.Text + "," + Convert.ToString(numGen()) + "," + "0" + "," + "0");
                mOutputStream.Close();
                this.Hide();
                AppLogin signUpForm = new AppLogin();
                signUpForm.ShowDialog();
                this.Close();
            }
        }

        private void signinLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppLogin signUpForm = new AppLogin();
            signUpForm.ShowDialog();
            this.Close();
        }
        private int numGen()
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (!File.Exists(applicationPath + "loyaltyNumbers.txt"))
            {
                StreamWriter myOutputStream = File.CreateText("loyaltyNumbers.txt");
                myOutputStream.Close();
            }

            //generates random loyalty number, checks that it is unique. and regenerates until it is
            
            Random rnd = new Random();
            int myRandomNum = rnd.Next(10000000, 99999999);
            bool uniqueNum = true;
            StreamReader numberReader = File.OpenText(applicationPath + "loyaltyNumbers.txt");
            string lineOfText = numberReader.ReadLine();
            while (lineOfText != null && uniqueNum == true)
            {
                if (lineOfText == Convert.ToString(myRandomNum))
                {
                    uniqueNum = false;
                }
                else
                {
                    lineOfText = numberReader.ReadLine();
                }
            }
            numberReader.Close();
            if (uniqueNum == false)
            {
                return numGen();
            }
            else
            {
                StreamWriter numberWriter =  File.AppendText("loyaltyNumbers.txt");
                numberWriter.WriteLine(Convert.ToString(myRandomNum));
                numberWriter.Close();
                return myRandomNum;
            }

        }
    }
}
