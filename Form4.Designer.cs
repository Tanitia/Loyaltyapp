
namespace Loyaltyapp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.genNumberLabel = new System.Windows.Forms.Label();
            this.balanceTextLabel = new System.Windows.Forms.Label();
            this.pointsGetLabel = new System.Windows.Forms.Label();
            this.moneyGetLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.voucherButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.simulateSpendButton = new System.Windows.Forms.Button();
            this.simulatePointsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
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
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loyalty";
            // 
            // QRBox
            // 
            this.QRBox.Image = ((System.Drawing.Image)(resources.GetObject("QRBox.Image")));
            this.QRBox.Location = new System.Drawing.Point(111, 129);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(156, 160);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRBox.TabIndex = 5;
            this.QRBox.TabStop = false;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(67, 305);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(115, 20);
            this.cardLabel.TabIndex = 8;
            this.cardLabel.Text = "Loyalty Card No";
            // 
            // genNumberLabel
            // 
            this.genNumberLabel.AutoSize = true;
            this.genNumberLabel.Location = new System.Drawing.Point(188, 305);
            this.genNumberLabel.Name = "genNumberLabel";
            this.genNumberLabel.Size = new System.Drawing.Size(15, 20);
            this.genNumberLabel.TabIndex = 14;
            this.genNumberLabel.Text = "-";
            // 
            // balanceTextLabel
            // 
            this.balanceTextLabel.AutoSize = true;
            this.balanceTextLabel.Location = new System.Drawing.Point(12, 353);
            this.balanceTextLabel.Name = "balanceTextLabel";
            this.balanceTextLabel.Size = new System.Drawing.Size(116, 20);
            this.balanceTextLabel.TabIndex = 15;
            this.balanceTextLabel.Text = "Current Balance:";
            // 
            // pointsGetLabel
            // 
            this.pointsGetLabel.AutoSize = true;
            this.pointsGetLabel.Location = new System.Drawing.Point(217, 353);
            this.pointsGetLabel.Name = "pointsGetLabel";
            this.pointsGetLabel.Size = new System.Drawing.Size(15, 20);
            this.pointsGetLabel.TabIndex = 16;
            this.pointsGetLabel.Text = "-";
            // 
            // moneyGetLabel
            // 
            this.moneyGetLabel.AutoSize = true;
            this.moneyGetLabel.Location = new System.Drawing.Point(217, 373);
            this.moneyGetLabel.Name = "moneyGetLabel";
            this.moneyGetLabel.Size = new System.Drawing.Size(15, 20);
            this.moneyGetLabel.TabIndex = 17;
            this.moneyGetLabel.Text = "-";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(281, 353);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(50, 20);
            this.pointsLabel.TabIndex = 18;
            this.pointsLabel.Text = "points";
            // 
            // voucherButton
            // 
            this.voucherButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.voucherButton.Location = new System.Drawing.Point(12, 397);
            this.voucherButton.Name = "voucherButton";
            this.voucherButton.Size = new System.Drawing.Size(148, 29);
            this.voucherButton.TabIndex = 19;
            this.voucherButton.Text = "Buy £5 E-Voucher";
            this.voucherButton.UseVisualStyleBackColor = false;
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.creditButton.Location = new System.Drawing.Point(217, 397);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(148, 29);
            this.creditButton.TabIndex = 20;
            this.creditButton.Text = "Buy £5 Credit";
            this.creditButton.UseVisualStyleBackColor = false;
            // 
            // simulateSpendButton
            // 
            this.simulateSpendButton.Location = new System.Drawing.Point(12, 432);
            this.simulateSpendButton.Name = "simulateSpendButton";
            this.simulateSpendButton.Size = new System.Drawing.Size(148, 29);
            this.simulateSpendButton.TabIndex = 21;
            this.simulateSpendButton.Text = "Simulate £5 Spend";
            this.simulateSpendButton.UseVisualStyleBackColor = true;
            this.simulateSpendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // simulatePointsButton
            // 
            this.simulatePointsButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simulatePointsButton.Location = new System.Drawing.Point(217, 432);
            this.simulatePointsButton.Name = "simulatePointsButton";
            this.simulatePointsButton.Size = new System.Drawing.Size(148, 29);
            this.simulatePointsButton.TabIndex = 22;
            this.simulatePointsButton.Text = "Simulate 500pts gain";
            this.simulatePointsButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(153, 467);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 501);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.simulatePointsButton);
            this.Controls.Add(this.simulateSpendButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.voucherButton);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.moneyGetLabel);
            this.Controls.Add(this.pointsGetLabel);
            this.Controls.Add(this.balanceTextLabel);
            this.Controls.Add(this.genNumberLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.QRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Name = "Form4";
            this.Text = "GAME Loyalty Shop";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label genNumberLabel;
        private System.Windows.Forms.Label balanceTextLabel;
        private System.Windows.Forms.Label pointsGetLabel;
        private System.Windows.Forms.Label moneyGetLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button voucherButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button simulateSpendButton;
        private System.Windows.Forms.Button simulatePointsButton;
        private System.Windows.Forms.Button backButton;
    }
}