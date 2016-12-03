namespace inventory
{
    partial class new_user
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
            this.new_username = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.Label();
            this.Administrator_Username = new System.Windows.Forms.Label();
            this.Administrator_Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_username
            // 
            this.new_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.new_username.Location = new System.Drawing.Point(331, 28);
            this.new_username.Name = "new_username";
            this.new_username.Size = new System.Drawing.Size(230, 30);
            this.new_username.TabIndex = 0;
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newPassword.Location = new System.Drawing.Point(331, 68);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(230, 30);
            this.newPassword.TabIndex = 1;
            // 
            // AdminPassword
            // 
            this.AdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AdminPassword.Location = new System.Drawing.Point(331, 183);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.PasswordChar = '*';
            this.AdminPassword.Size = new System.Drawing.Size(230, 30);
            this.AdminPassword.TabIndex = 5;
            // 
            // adminUsername
            // 
            this.adminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.adminUsername.Location = new System.Drawing.Point(331, 141);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(230, 30);
            this.adminUsername.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Username.Location = new System.Drawing.Point(95, 28);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(146, 25);
            this.Username.TabIndex = 4;
            this.Username.Text = "New Username";
            // 
            // new_password
            // 
            this.new_password.AutoSize = true;
            this.new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.new_password.Location = new System.Drawing.Point(95, 68);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(142, 25);
            this.new_password.TabIndex = 5;
            this.new_password.Text = "New Password";
            // 
            // Administrator_Username
            // 
            this.Administrator_Username.AutoSize = true;
            this.Administrator_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Administrator_Username.Location = new System.Drawing.Point(89, 141);
            this.Administrator_Username.Name = "Administrator_Username";
            this.Administrator_Username.Size = new System.Drawing.Size(221, 25);
            this.Administrator_Username.TabIndex = 6;
            this.Administrator_Username.Text = "Administrator Username";
            // 
            // Administrator_Password
            // 
            this.Administrator_Password.AutoSize = true;
            this.Administrator_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Administrator_Password.Location = new System.Drawing.Point(89, 183);
            this.Administrator_Password.Name = "Administrator_Password";
            this.Administrator_Password.Size = new System.Drawing.Size(217, 25);
            this.Administrator_Password.TabIndex = 7;
            this.Administrator_Password.Text = "Administrator Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(331, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(95, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.confirmPassword.Location = new System.Drawing.Point(331, 105);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(230, 30);
            this.confirmPassword.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(507, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Administrator_Password);
            this.Controls.Add(this.Administrator_Username);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.AdminPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.new_username);
            this.Name = "new_user";
            this.Text = "new_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_username;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox AdminPassword;
        private System.Windows.Forms.TextBox adminUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label new_password;
        private System.Windows.Forms.Label Administrator_Username;
        private System.Windows.Forms.Label Administrator_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button button2;
    }
}