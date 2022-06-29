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

        private void simulateSpendButton_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (moneyGetLabel.Text != "-") {
                if (Convert.ToInt16(moneyGetLabel.Text) >= 5) {
                int money = Convert.ToInt16(moneyGetLabel.Text);
                money = money - 5;
                moneyGetLabel.Text = Convert.ToString(money);
                StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
                string email = customerReader.ReadLine().Trim();
                customerReader.Close();
                var reader = new StreamReader(File.OpenRead(applicationPath + "userInfo.txt"));
                List<List<string>> allUsers = new List<List<string>>();
                List<string> user;
                while (!reader.EndOfStream)
                {
                    user = new List<string>();
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    foreach (var i in values)
                    {
                        user.Add(i);
                    }

                    allUsers.Add(user);
                    Console.WriteLine(allUsers);
                }
                reader.Close();
                foreach (var i in allUsers)
                {
                    if (i[1] == email)
                    {
                        i[5] = Convert.ToString(money);

                    }
                }
                StreamWriter writer = File.CreateText(applicationPath + "userInfo.txt");
                foreach (var i in allUsers)
                {
                    writer.WriteLine(i[0] + "," + i[1] + "," + i[2] + ","
                        + i[3] + "," + i[4] + "," + i[5] + "," + i[6] + ","
                        + i[7] + "," + i[8]);
                }
                writer.Close();
            }
        }
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
            moneyGetLabel.Text = money;
            detailsReader.Close();
        }

        private void voucherButton_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (pointsGetLabel.Text != "-") {
                if (Convert.ToInt16(pointsGetLabel.Text) >= 500)
                {
                    int currentPoints = Convert.ToInt16(pointsGetLabel.Text);
                    int money = Convert.ToInt16(moneyGetLabel.Text);
                    money = money + 5;
                    currentPoints = currentPoints - 500;
                    pointsGetLabel.Text = Convert.ToString(currentPoints);
                    moneyGetLabel.Text = Convert.ToString(money);
                    StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
                    string email = customerReader.ReadLine().Trim();
                    customerReader.Close();
                    var reader = new StreamReader(File.OpenRead(applicationPath + "userInfo.txt"));
                    List<List<string>> allUsers = new List<List<string>>();
                    List<string> user;
                    while (!reader.EndOfStream)
                    {
                        user = new List<string>();
                        var line = reader.ReadLine();
                        string[] values = line.Split(',');
                        foreach (var i in values)
                        {
                            user.Add(i);
                        }

                        allUsers.Add(user);
                        Console.WriteLine(allUsers);
                    }
                    reader.Close();
                    foreach (var i in allUsers) {
                        if (i[1] == email) {
                            i[5] = Convert.ToString(money);
                            i[4] = Convert.ToString(currentPoints);
                            int num = Convert.ToInt16(i[8]);
                            int finishedNum = num + 1;
                            i[8] = Convert.ToString(finishedNum);
                        
                        }
                    }
                    StreamWriter writer = File.CreateText(applicationPath + "userInfo.txt");
                    foreach(var i in allUsers)
                    {
                        writer.WriteLine(i[0] + "," + i[1] + "," + i[2] + ","
                            + i[3] + "," + i[4] + "," + i[5] + "," + i[6] + ","
                            + i[7] + "," + i[8]);
                    }
                    writer.Close();
                }   
            }
        }

        private void simulatePointsButton_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (pointsGetLabel.Text != "-") {
                int currentPoints = Convert.ToInt16(pointsGetLabel.Text);
                currentPoints = currentPoints + 500;
                pointsGetLabel.Text = Convert.ToString(currentPoints);
                StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
                string email = customerReader.ReadLine().Trim();
                customerReader.Close();
                var reader = new StreamReader(File.OpenRead(applicationPath + "userInfo.txt"));
         
                List<List<string>> allUsers = new List<List<string>>();
                List<string> user;
                while (!reader.EndOfStream)
                {
                    user = new List<string>();
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    foreach (var i in values)
                    {
                        user.Add(i);

                    }

                    allUsers.Add(user);
                    
                }
                reader.Close();
                foreach (var i in allUsers)
                {
                    if (i[1] == email)
                    {
                        i[4] = Convert.ToString(currentPoints);
                        int num = Convert.ToInt16(i[6]);
                        int finishedNum = num + 500;
                        i[6] = Convert.ToString(finishedNum);

                    }
                }
                StreamWriter writer = File.CreateText(applicationPath + "userInfo.txt");
                foreach (var i in allUsers)
                {
                    writer.WriteLine(i[0] + "," + i[1] + "," + i[2] + ","
                        + i[3] + "," + i[4] + "," + i[5] + "," + i[6] + ","
                        + i[7] + "," + i[8]);
                }
                writer.Close();
            }
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            if (pointsGetLabel.Text != "-")
            {
                if (Convert.ToInt16(pointsGetLabel.Text) >= 500)
                {
                    int currentPoints = Convert.ToInt16(pointsGetLabel.Text);
                    int money = Convert.ToInt16(moneyGetLabel.Text);
                    money = money + 5;
                    currentPoints = currentPoints - 500;
                    pointsGetLabel.Text = Convert.ToString(currentPoints);
                    moneyGetLabel.Text = Convert.ToString(money);
                    StreamReader customerReader = File.OpenText(applicationPath + "currentUser.txt");
                    string email = customerReader.ReadLine().Trim();
                    customerReader.Close();
                    var reader = new StreamReader(File.OpenRead(applicationPath + "userInfo.txt"));
                    List<List<string>> allUsers = new List<List<string>>();
                    List<string> user;
                    while (!reader.EndOfStream)
                    {
                        user = new List<string>();
                        var line = reader.ReadLine();
                        string[] values = line.Split(',');
                        foreach (var i in values)
                        {
                            user.Add(i);
                        }

                        allUsers.Add(user);
                        Console.WriteLine(allUsers);
                    }
                    reader.Close();
                    foreach (var i in allUsers)
                    {
                        if (i[1] == email)
                        {
                            i[5] = Convert.ToString(money);
                            i[4] = Convert.ToString(currentPoints);
                            int num = Convert.ToInt16(i[7]);
                            int finishedNum = num + 5;
                            i[7] = Convert.ToString(finishedNum);

                        }
                    }
                    StreamWriter writer = File.CreateText(applicationPath + "userInfo.txt");
                    foreach (var i in allUsers)
                    {
                        writer.WriteLine(i[0] + "," + i[1] + "," + i[2] + ","
                            + i[3] + "," + i[4] + "," + i[5] + "," + i[6] + ","
                            + i[7] + "," + i[8]);
                    }
                    writer.Close();
                }
            }
        }
    }
}
