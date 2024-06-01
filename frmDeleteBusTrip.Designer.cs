namespace suBilet
{
    partial class frmDeleteBusTrip
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
            this.busesdgw = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.busesdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // busesdgw
            // 
            this.busesdgw.AllowUserToAddRows = false;
            this.busesdgw.AllowUserToDeleteRows = false;
            this.busesdgw.AllowUserToResizeColumns = false;
            this.busesdgw.AllowUserToResizeRows = false;
            this.busesdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesdgw.Location = new System.Drawing.Point(75, 48);
            this.busesdgw.Name = "busesdgw";
            this.busesdgw.ReadOnly = true;
            this.busesdgw.RowHeadersWidth = 51;
            this.busesdgw.RowTemplate.Height = 29;
            this.busesdgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.busesdgw.Size = new System.Drawing.Size(589, 335);
            this.busesdgw.TabIndex = 0;
            this.busesdgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busesdgw_CellContentClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(338, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Vazgeç";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // frmDeleteBusTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.busesdgw);
            this.Name = "frmDeleteBusTrip";
            this.Text = "frmDeleteBusTrip";
            this.Load += new System.EventHandler(this.frmDeleteBusTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busesdgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView busesdgw;
        private System.Windows.Forms.Button cancelButton;
    }
}