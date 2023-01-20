namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    partial class HastaIslemleri
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
            this.hastalarDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaTcTxt = new System.Windows.Forms.TextBox();
            this.hastaAdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hastaDogumYeriTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaSoyadTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hastaDogumTarihiTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telefonNoTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hastaKaydetBtn = new System.Windows.Forms.Button();
            this.hastalariListeleBtn = new System.Windows.Forms.Button();
            this.menuFrmBtn = new System.Windows.Forms.Button();
            this.medeniDrmBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hastaSilBtn = new System.Windows.Forms.Button();
            this.silinecekHastaTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastalarDataGrid
            // 
            this.hastalarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalarDataGrid.Location = new System.Drawing.Point(21, 41);
            this.hastalarDataGrid.Name = "hastalarDataGrid";
            this.hastalarDataGrid.RowTemplate.Height = 25;
            this.hastalarDataGrid.Size = new System.Drawing.Size(836, 225);
            this.hastalarDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıtlı Hastalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta TC";
            // 
            // hastaTcTxt
            // 
            this.hastaTcTxt.Location = new System.Drawing.Point(124, 298);
            this.hastaTcTxt.Name = "hastaTcTxt";
            this.hastaTcTxt.Size = new System.Drawing.Size(132, 23);
            this.hastaTcTxt.TabIndex = 3;
            this.hastaTcTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hastaTcTxt_KeyPress);
            // 
            // hastaAdTxt
            // 
            this.hastaAdTxt.Location = new System.Drawing.Point(124, 353);
            this.hastaAdTxt.Name = "hastaAdTxt";
            this.hastaAdTxt.Size = new System.Drawing.Size(132, 23);
            this.hastaAdTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta Adı";
            // 
            // hastaDogumYeriTxt
            // 
            this.hastaDogumYeriTxt.Location = new System.Drawing.Point(124, 454);
            this.hastaDogumYeriTxt.Name = "hastaDogumYeriTxt";
            this.hastaDogumYeriTxt.Size = new System.Drawing.Size(132, 23);
            this.hastaDogumYeriTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Yeri";
            // 
            // hastaSoyadTxt
            // 
            this.hastaSoyadTxt.Location = new System.Drawing.Point(124, 406);
            this.hastaSoyadTxt.Name = "hastaSoyadTxt";
            this.hastaSoyadTxt.Size = new System.Drawing.Size(132, 23);
            this.hastaSoyadTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasta Soyadı";
            // 
            // hastaDogumTarihiTxt
            // 
            this.hastaDogumTarihiTxt.Location = new System.Drawing.Point(124, 502);
            this.hastaDogumTarihiTxt.Name = "hastaDogumTarihiTxt";
            this.hastaDogumTarihiTxt.Size = new System.Drawing.Size(132, 23);
            this.hastaDogumTarihiTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medeni Durum";
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(410, 406);
            this.adresTxt.Multiline = true;
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(132, 73);
            this.adresTxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres";
            // 
            // telefonNoTxt
            // 
            this.telefonNoTxt.Location = new System.Drawing.Point(410, 353);
            this.telefonNoTxt.Name = "telefonNoTxt";
            this.telefonNoTxt.Size = new System.Drawing.Size(132, 23);
            this.telefonNoTxt.TabIndex = 17;
            this.telefonNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonNoTxt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon No";
            // 
            // hastaKaydetBtn
            // 
            this.hastaKaydetBtn.Location = new System.Drawing.Point(664, 318);
            this.hastaKaydetBtn.Name = "hastaKaydetBtn";
            this.hastaKaydetBtn.Size = new System.Drawing.Size(128, 36);
            this.hastaKaydetBtn.TabIndex = 18;
            this.hastaKaydetBtn.Text = "Hastayı Kaydet";
            this.hastaKaydetBtn.UseVisualStyleBackColor = true;
            this.hastaKaydetBtn.Click += new System.EventHandler(this.hastaKaydetBtn_Click);
            // 
            // hastalariListeleBtn
            // 
            this.hastalariListeleBtn.Location = new System.Drawing.Point(664, 388);
            this.hastalariListeleBtn.Name = "hastalariListeleBtn";
            this.hastalariListeleBtn.Size = new System.Drawing.Size(128, 36);
            this.hastalariListeleBtn.TabIndex = 19;
            this.hastalariListeleBtn.Text = "Hastaları Listele";
            this.hastalariListeleBtn.UseVisualStyleBackColor = true;
            this.hastalariListeleBtn.Click += new System.EventHandler(this.hastalariListeleBtn_Click);
            // 
            // menuFrmBtn
            // 
            this.menuFrmBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuFrmBtn.Location = new System.Drawing.Point(664, 454);
            this.menuFrmBtn.Name = "menuFrmBtn";
            this.menuFrmBtn.Size = new System.Drawing.Size(128, 36);
            this.menuFrmBtn.TabIndex = 20;
            this.menuFrmBtn.Text = "Menüye Dön";
            this.menuFrmBtn.UseVisualStyleBackColor = false;
            this.menuFrmBtn.Click += new System.EventHandler(this.menuFrmBtn_Click);
            // 
            // medeniDrmBox
            // 
            this.medeniDrmBox.FormattingEnabled = true;
            this.medeniDrmBox.Items.AddRange(new object[] {
            "EVLI",
            "BEKAR"});
            this.medeniDrmBox.Location = new System.Drawing.Point(410, 298);
            this.medeniDrmBox.Name = "medeniDrmBox";
            this.medeniDrmBox.Size = new System.Drawing.Size(132, 23);
            this.medeniDrmBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.hastaSilBtn);
            this.groupBox1.Controls.Add(this.silinecekHastaTxt);
            this.groupBox1.Location = new System.Drawing.Point(407, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 59);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TC ile Hasta Sil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hasta TC";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // hastaSilBtn
            // 
            this.hastaSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.hastaSilBtn.Location = new System.Drawing.Point(254, 17);
            this.hastaSilBtn.Name = "hastaSilBtn";
            this.hastaSilBtn.Size = new System.Drawing.Size(128, 36);
            this.hastaSilBtn.TabIndex = 23;
            this.hastaSilBtn.Text = "Sil";
            this.hastaSilBtn.UseVisualStyleBackColor = false;
            this.hastaSilBtn.Click += new System.EventHandler(this.hastaSilBtn_Click);
            // 
            // silinecekHastaTxt
            // 
            this.silinecekHastaTxt.Location = new System.Drawing.Point(89, 26);
            this.silinecekHastaTxt.Name = "silinecekHastaTxt";
            this.silinecekHastaTxt.Size = new System.Drawing.Size(132, 23);
            this.silinecekHastaTxt.TabIndex = 23;
            this.silinecekHastaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.silinecekHastaTxt_KeyPress);
            // 
            // HastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.medeniDrmBox);
            this.Controls.Add(this.menuFrmBtn);
            this.Controls.Add(this.hastalariListeleBtn);
            this.Controls.Add(this.hastaKaydetBtn);
            this.Controls.Add(this.telefonNoTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hastaDogumTarihiTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hastaSoyadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hastaDogumYeriTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaAdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hastaTcTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastalarDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView hastalarDataGrid;
        private Label label1;
        private Label label2;
        private TextBox hastaTcTxt;
        private TextBox hastaAdTxt;
        private Label label3;
        private TextBox hastaDogumYeriTxt;
        private Label label4;
        private TextBox hastaSoyadTxt;
        private Label label5;
        private TextBox hastaDogumTarihiTxt;
        private Label label6;
        private Label label7;
        private TextBox adresTxt;
        private Label label8;
        private TextBox telefonNoTxt;
        private Label label9;
        private Button hastaKaydetBtn;
        private Button hastalariListeleBtn;
        private Button menuFrmBtn;
        private ComboBox medeniDrmBox;
        private GroupBox groupBox1;
        private Label label10;
        private Button hastaSilBtn;
        private TextBox silinecekHastaTxt;
    }
}