namespace buBilet
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_username = new System.Windows.Forms.TextBox();
            this.Login_pswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_showPswd = new System.Windows.Forms.CheckBox();
            this.Login_loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.login_to_register = new System.Windows.Forms.LinkLabel();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_username
            // 
            this.Login_username.Location = new System.Drawing.Point(43, 132);
            this.Login_username.Name = "Login_username";
            this.Login_username.Size = new System.Drawing.Size(184, 27);
            this.Login_username.TabIndex = 0;
            // 
            // Login_pswd
            // 
            this.Login_pswd.Location = new System.Drawing.Point(43, 220);
            this.Login_pswd.Name = "Login_pswd";
            this.Login_pswd.Size = new System.Drawing.Size(184, 27);
            this.Login_pswd.TabIndex = 1;
            this.Login_pswd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // Login_showPswd
            // 
            this.Login_showPswd.AutoSize = true;
            this.Login_showPswd.Location = new System.Drawing.Point(43, 276);
            this.Login_showPswd.Name = "Login_showPswd";
            this.Login_showPswd.Size = new System.Drawing.Size(130, 24);
            this.Login_showPswd.TabIndex = 4;
            this.Login_showPswd.Text = "Parolayı Göster";
            this.Login_showPswd.UseVisualStyleBackColor = true;
            this.Login_showPswd.CheckedChanged += new System.EventHandler(this.Login_showPswd_CheckedChanged);
            // 
            // Login_loginButton
            // 
            this.Login_loginButton.Location = new System.Drawing.Point(44, 329);
            this.Login_loginButton.Name = "Login_loginButton";
            this.Login_loginButton.Size = new System.Drawing.Size(94, 29);
            this.Login_loginButton.TabIndex = 5;
            this.Login_loginButton.Text = "Giriş Yap";
            this.Login_loginButton.UseVisualStyleBackColor = true;
            this.Login_loginButton.Click += new System.EventHandler(this.Login_loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabınız Yok mu?";
            // 
            // login_to_register
            // 
            this.login_to_register.AutoSize = true;
            this.login_to_register.Location = new System.Drawing.Point(183, 387);
            this.login_to_register.Name = "login_to_register";
            this.login_to_register.Size = new System.Drawing.Size(61, 20);
            this.login_to_register.TabIndex = 7;
            this.login_to_register.TabStop = true;
            this.login_to_register.Text = "Kayıt Ol";
            this.login_to_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_to_register_LinkClicked);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xLabel.Location = new System.Drawing.Point(533, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(26, 28);
            this.xLabel.TabIndex = 8;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 503);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.login_to_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_loginButton);
            this.Controls.Add(this.Login_showPswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_pswd);
            this.Controls.Add(this.Login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_username;
        private System.Windows.Forms.TextBox Login_pswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Login_showPswd;
        private System.Windows.Forms.Button Login_loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel login_to_register;
        private System.Windows.Forms.Label xLabel;
    }
}
