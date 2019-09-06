namespace FinalProject
{
    partial class Login
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.btn_LOGIN = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(177, 123);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 18);
            this.username.TabIndex = 0;
            this.username.Text = "Admin Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(177, 186);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 18);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(372, 176);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(100, 28);
            this.PasswordTXT.TabIndex = 2;
            this.PasswordTXT.UseSystemPasswordChar = true;
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Location = new System.Drawing.Point(372, 120);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(100, 28);
            this.UsernameTXT.TabIndex = 3;
            this.UsernameTXT.TextChanged += new System.EventHandler(this.UsernameTXT_TextChanged);
            // 
            // btn_LOGIN
            // 
            this.btn_LOGIN.Location = new System.Drawing.Point(470, 287);
            this.btn_LOGIN.Name = "btn_LOGIN";
            this.btn_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.btn_LOGIN.TabIndex = 4;
            this.btn_LOGIN.Text = "Log in";
            this.btn_LOGIN.UseVisualStyleBackColor = true;
            this.btn_LOGIN.Click += new System.EventHandler(this.Btn_LOGIN_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(621, 368);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_LOGIN);
            this.Controls.Add(this.UsernameTXT);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.Button btn_LOGIN;
        private System.Windows.Forms.Button btn_back;
    }
}