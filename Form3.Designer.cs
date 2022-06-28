
namespace Loyaltyapp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.pastButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.cardLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.welcomeNameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.signoutButton = new System.Windows.Forms.Button();
            this.genNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(122, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(125, 41);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loyalty";
            // 
            // QRBox
            // 
            this.QRBox.Image = ((System.Drawing.Image)(resources.GetObject("QRBox.Image")));
            this.QRBox.Location = new System.Drawing.Point(111, 129);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(156, 160);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRBox.TabIndex = 4;
            this.QRBox.TabStop = false;
            this.QRBox.Click += new System.EventHandler(this.QRBox_Click);
            // 
            // pastButton
            // 
            this.pastButton.Location = new System.Drawing.Point(111, 397);
            this.pastButton.Name = "pastButton";
            this.pastButton.Size = new System.Drawing.Size(167, 29);
            this.pastButton.TabIndex = 5;
            this.pastButton.Text = "Past Rewards";
            this.pastButton.UseVisualStyleBackColor = true;
            this.pastButton.Click += new System.EventHandler(this.pastButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(111, 349);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(167, 29);
            this.shopButton.TabIndex = 6;
            this.shopButton.Text = "Wallet and Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(67, 305);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(115, 20);
            this.cardLabel.TabIndex = 7;
            this.cardLabel.Text = "Loyalty Card No";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(111, 98);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(72, 20);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(190, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 9;
            // 
            // welcomeNameLabel
            // 
            this.welcomeNameLabel.AutoSize = true;
            this.welcomeNameLabel.Location = new System.Drawing.Point(188, 98);
            this.welcomeNameLabel.Name = "welcomeNameLabel";
            this.welcomeNameLabel.Size = new System.Drawing.Size(15, 20);
            this.welcomeNameLabel.TabIndex = 10;
            this.welcomeNameLabel.Tag = "";
            this.welcomeNameLabel.Text = "-";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(188, 305);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 20);
            this.numberLabel.TabIndex = 11;
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(111, 444);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(167, 29);
            this.signoutButton.TabIndex = 12;
            this.signoutButton.Text = "Sign-out";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // genNumberLabel
            // 
            this.genNumberLabel.AutoSize = true;
            this.genNumberLabel.Location = new System.Drawing.Point(188, 305);
            this.genNumberLabel.Name = "genNumberLabel";
            this.genNumberLabel.Size = new System.Drawing.Size(15, 20);
            this.genNumberLabel.TabIndex = 13;
            this.genNumberLabel.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 501);
            this.Controls.Add(this.genNumberLabel);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.welcomeNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.pastButton);
            this.Controls.Add(this.QRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Name = "Form3";
            this.Text = "GAME Loyalty Home";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Button pastButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label welcomeNameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Label genNumberLabel;
    }
}