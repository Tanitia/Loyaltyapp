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
            //checking credential validity
            if (emailTextbox.Text.Contains("@") && nameTextbox.Text != null && emailTextbox.Text != null && passwordTextbox.Text != null)
            {
                string applicationPath = Directory.GetCurrentDirectory() + "\\";
                if (!File.Exists(applicationPath + "userInfo.txt"))
                {
                    //creates file to hold user details if it doesn't exist
                    //(functionality such as this would be done via db in live versions)
                    StreamWriter myOutputStream = File.CreateText("userInfo.txt");
                    myOutputStream.Close();
                }
                bool found = false;
                StreamReader detailsReader = File.OpenText(applicationPath + "userInfo.txt");
                string lineOfText = detailsReader.ReadLine();
                while (lineOfText != null && found == false)
                {
                    string[] individual = lineOfText.Split(',');
                    if (emailTextbox.Text == individual[1])
                    {
                        found = true;

                    }
                    lineOfText = detailsReader.ReadLine();
                }
                detailsReader.Close();
                //if unique email
                if (found == false)
                {

                    StreamWriter mOutputStream = File.AppendText(applicationPath + "userInfo.txt");
                    mOutputStream.WriteLine(nameTextbox.Text + "," + emailTextbox.Text + "," + passwordTextbox.Text + "," + Convert.ToString(numGen()) + "," + "0" + "," + "0" + "," + "0" + "," + "0" + "," + "0");
                    mOutputStream.Close();
                    this.Hide();
                    AppLogin signUpForm = new AppLogin();
                    signUpForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    newMessageLabel.Text = "That email is already used"; //updates gui
                }

            }
            else {
                newMessageLabel.Text = "Fields cannot be blank, emails must contain '@'"; //updates gui
            }
        }

        private void signinLabel_Click(object sender, EventArgs e)
        {
            //load login screen
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
