namespace suBilet
{
    partial class frmAdminMain
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
            this.createAdminAccount = new System.Windows.Forms.Button();
            this.createBusTrip = new System.Windows.Forms.Button();
            this.deleteBusTrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAdminAccount
            // 
            this.createAdminAccount.Location = new System.Drawing.Point(12, 52);
            this.createAdminAccount.Name = "createAdminAccount";
            this.createAdminAccount.Size = new System.Drawing.Size(179, 29);
            this.createAdminAccount.TabIndex = 0;
            this.createAdminAccount.Text = "Yetkili Hesap Ekle";
            this.createAdminAccount.UseVisualStyleBackColor = true;
            this.createAdminAccount.Click += new System.EventHandler(this.createAdminAccount_Click);
            // 
            // createBusTrip
            // 
            this.createBusTrip.Location = new System.Drawing.Point(609, 52);
            this.createBusTrip.Name = "createBusTrip";
            this.createBusTrip.Size = new System.Drawing.Size(179, 29);
            this.createBusTrip.TabIndex = 1;
            this.createBusTrip.Text = "Sefer Oluştur";
            this.createBusTrip.UseVisualStyleBackColor = true;
            this.createBusTrip.Click += new System.EventHandler(this.createBusTrip_Click);
            // 
            // deleteBusTrip
            // 
            this.deleteBusTrip.Location = new System.Drawing.Point(609, 114);
            this.deleteBusTrip.Name = "deleteBusTrip";
            this.deleteBusTrip.Size = new System.Drawing.Size(179, 29);
            this.deleteBusTrip.TabIndex = 2;
            this.deleteBusTrip.Text = "Sefer Sil";
            this.deleteBusTrip.UseVisualStyleBackColor = true;
            this.deleteBusTrip.Click += new System.EventHandler(this.deleteBusTrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(762, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(609, 409);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(179, 29);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Çıkış Yap";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBusTrip);
            this.Controls.Add(this.createBusTrip);
            this.Controls.Add(this.createAdminAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMain";
            this.Text = "frmAdminMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAdminAccount;
        private System.Windows.Forms.Button createBusTrip;
        private System.Windows.Forms.Button deleteBusTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
    }
}