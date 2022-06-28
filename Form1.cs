using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loyaltyapp
{
    public partial class AppLogin : Form
    {
        public AppLogin()
        {
            InitializeComponent();
        }

        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 signUpForm = new Form2();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            StreamReader myInputStream = File.OpenText("userInfo.txt");
            string lineOfText = myInputStream.ReadLine();
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            while (lineOfText != null && found == false) {
                string[] individual = lineOfText.Split(',');
                if (email == individual[1].Trim())
                {
                    if (password == individual[2].Trim())
                    {
                        found = true;
                    }
                }
                else {
                    lineOfText = myInputStream.ReadLine();
                }

            }
            myInputStream.Close();
            if (found == false)
            {
                errorLabel.Text = "Please check login details";
            }
            else {
                StreamWriter currentUserWriter = File.CreateText(applicationPath + "currentUser.txt");
                currentUserWriter.Write(emailTextbox.Text);
                currentUserWriter.Close();
                
                Form3 homeForm = new Form3();
                this.Hide();
                homeForm.ShowDialog();
                this.Close();
            }
            
        }
    }
}
