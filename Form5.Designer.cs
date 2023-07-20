
namespace Loyaltyapp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.welcomeNameLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.genNumberLabel = new System.Windows.Forms.Label();
            this.thanksLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.vouchersLabel = new System.Windows.Forms.Label();
            this.cashbackLabel = new System.Windows.Forms.Label();
            this.earnedLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
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
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loyalty";
            // 
            // QRBox
            // 
            this.QRBox.Image = ((System.Drawing.Image)(resources.GetObject("QRBox.Image")));
            this.QRBox.Location = new System.Drawing.Point(111, 129);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(156, 160);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRBox.TabIndex = 6;
            this.QRBox.TabStop = false;
            this.QRBox.Click += new System.EventHandler(this.QRBox_Click);
            // 
            // welcomeNameLabel
            // 
            this.welcomeNameLabel.AutoSize = true;
            this.welcomeNameLabel.Location = new System.Drawing.Point(86, 106);
            this.welcomeNameLabel.Name = "welcomeNameLabel";
            this.welcomeNameLabel.Size = new System.Drawing.Size(193, 20);
            this.welcomeNameLabel.TabIndex = 11;
            this.welcomeNameLabel.Tag = "";
            this.welcomeNameLabel.Text = "Hi! Please scan to show info";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(67, 305);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(115, 20);
            this.cardLabel.TabIndex = 12;
            this.cardLabel.Text = "Loyalty Card No";
            // 
            // genNumberLabel
            // 
            this.genNumberLabel.AutoSize = true;
            this.genNumberLabel.Location = new System.Drawing.Point(188, 305);
            this.genNumberLabel.Name = "genNumberLabel";
            this.genNumberLabel.Size = new System.Drawing.Size(15, 20);
            this.genNumberLabel.TabIndex = 15;
            this.genNumberLabel.Text = "-";
            // 
            // thanksLabel
            // 
            this.thanksLabel.AutoSize = true;
            this.thanksLabel.Location = new System.Drawing.Point(97, 337);
            this.thanksLabel.Name = "thanksLabel";
            this.thanksLabel.Size = new System.Drawing.Size(182, 20);
            this.thanksLabel.TabIndex = 16;
            this.thanksLabel.Text = "Thanks for staying with us!";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(53, 357);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(285, 20);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "During our time with us, you have bought:";
            // 
            // vouchersLabel
            // 
            this.vouchersLabel.AutoSize = true;
            this.vouchersLabel.Location = new System.Drawing.Point(169, 386);
            this.vouchersLabel.Name = "vouchersLabel";
            this.vouchersLabel.Size = new System.Drawing.Size(78, 20);
            this.vouchersLabel.TabIndex = 18;
            this.vouchersLabel.Text = "x vouchers";
            // 
            // cashbackLabel
            // 
            this.cashbackLabel.AutoSize = true;
            this.cashbackLabel.Location = new System.Drawing.Point(169, 406);
            this.cashbackLabel.Name = "cashbackLabel";
            this.cashbackLabel.Size = new System.Drawing.Size(80, 20);
            this.cashbackLabel.TabIndex = 19;
            this.cashbackLabel.Text = "x cashback";
            // 
            // earnedLabel
            // 
            this.earnedLabel.AutoSize = true;
            this.earnedLabel.Location = new System.Drawing.Point(111, 426);
            this.earnedLabel.Name = "earnedLabel";
            this.earnedLabel.Size = new System.Drawing.Size(188, 20);
            this.earnedLabel.TabIndex = 20;
            this.earnedLabel.Text = "And earned x points! Wow!";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(153, 460);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(111, 285);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(156, 17);
            this.messageLabel.TabIndex = 22;
            this.messageLabel.Text = "Scan QR to show history";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 501);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.earnedLabel);
            this.Controls.Add(this.cashbackLabel);
            this.Controls.Add(this.vouchersLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.thanksLabel);
            this.Controls.Add(this.genNumberLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.welcomeNameLabel);
            this.Controls.Add(this.QRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Name = "Form5";
            this.Text = "GAME Loyalty Past Rewards";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Label welcomeNameLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label genNumberLabel;
        private System.Windows.Forms.Label thanksLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label vouchersLabel;
        private System.Windows.Forms.Label cashbackLabel;
        private System.Windows.Forms.Label earnedLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label messageLabel;
    }
}