
namespace Loyaltyapp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.signinLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(122, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(125, 41);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loyalty";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(73, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.nameTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameTextbox.Location = new System.Drawing.Point(73, 147);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(231, 27);
            this.nameTextbox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(73, 186);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.emailTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.emailTextbox.Location = new System.Drawing.Point(73, 209);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(231, 27);
            this.emailTextbox.TabIndex = 7;
            // 
            // signupButton
            // 
            this.signupButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.signupButton.Location = new System.Drawing.Point(145, 351);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(94, 29);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Sign-up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signinLabel.Location = new System.Drawing.Point(162, 404);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(56, 20);
            this.signinLabel.TabIndex = 9;
            this.signinLabel.Text = "Sign-in";
            this.signinLabel.Click += new System.EventHandler(this.signinLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(76, 251);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 20);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.passwordTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordTextbox.Location = new System.Drawing.Point(73, 274);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(231, 27);
            this.passwordTextbox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 501);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.signinLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Name = "Form2";
            this.Text = "GAME Loyalty Sign-up";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label signinLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}