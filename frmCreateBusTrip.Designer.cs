namespace suBilet
{
    partial class frmCreateBusTrip
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
            this.saveTripButton = new System.Windows.Forms.Button();
            this.fromCityBox = new System.Windows.Forms.ComboBox();
            this.toCityBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.companiesBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveTripButton
            // 
            this.saveTripButton.Location = new System.Drawing.Point(12, 370);
            this.saveTripButton.Name = "saveTripButton";
            this.saveTripButton.Size = new System.Drawing.Size(154, 29);
            this.saveTripButton.TabIndex = 0;
            this.saveTripButton.Text = "Seferi Kaydet";
            this.saveTripButton.UseVisualStyleBackColor = true;
            this.saveTripButton.Click += new System.EventHandler(this.saveTripButton_Click);
            // 
            // fromCityBox
            // 
            this.fromCityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromCityBox.FormattingEnabled = true;
            this.fromCityBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.fromCityBox.Location = new System.Drawing.Point(449, 41);
            this.fromCityBox.Name = "fromCityBox";
            this.fromCityBox.Size = new System.Drawing.Size(151, 28);
            this.fromCityBox.TabIndex = 3;
            // 
            // toCityBox
            // 
            this.toCityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toCityBox.FormattingEnabled = true;
            this.toCityBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.toCityBox.Location = new System.Drawing.Point(637, 38);
            this.toCityBox.Name = "toCityBox";
            this.toCityBox.Size = new System.Drawing.Size(151, 28);
            this.toCityBox.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(12, 39);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(250, 27);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(268, 39);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(154, 27);
            this.timePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sefer Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sefer Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalkış Şehri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Varış Şehri:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 370);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 29);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Vazgeç";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // companiesBox
            // 
            this.companiesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companiesBox.FormattingEnabled = true;
            this.companiesBox.Items.AddRange(new object[] {
            "Metro Turizm",
            "Kamil Koc",
            "Pamukkale",
            "Varan Turizm",
            "Safran Turizm",
            "Luks Artvin"});
            this.companiesBox.Location = new System.Drawing.Point(12, 100);
            this.companiesBox.Name = "companiesBox";
            this.companiesBox.Size = new System.Drawing.Size(119, 28);
            this.companiesBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firmalar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "*Yalnızca Anlaşmalı Firmalar Mevcuttur.";
            // 
            // frmCreateBusTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.companiesBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.toCityBox);
            this.Controls.Add(this.fromCityBox);
            this.Controls.Add(this.saveTripButton);
            this.Name = "frmCreateBusTrip";
            this.Text = "frmCreateBusTrip";
            this.Load += new System.EventHandler(this.frmCreateBusTrip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveTripButton;
        private System.Windows.Forms.ComboBox fromCityBox;
        private System.Windows.Forms.ComboBox toCityBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox companiesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}