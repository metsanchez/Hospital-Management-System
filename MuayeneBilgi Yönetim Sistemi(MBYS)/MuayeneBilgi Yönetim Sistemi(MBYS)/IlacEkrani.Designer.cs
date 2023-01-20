namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    partial class IlacEkrani
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
            this.ilaclarDataGrid = new System.Windows.Forms.DataGridView();
            this.menuFrmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ilacBarkodTxt = new System.Windows.Forms.TextBox();
            this.ilacAdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ilacTipBox = new System.Windows.Forms.ComboBox();
            this.ilacKaydetBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ilacSilBtn = new System.Windows.Forms.Button();
            this.silinecekIlacBarkodTxt = new System.Windows.Forms.TextBox();
            this.ilacListeleBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hastalarDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barkodAratBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaBulTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilaclarDataGrid
            // 
            this.ilaclarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilaclarDataGrid.Location = new System.Drawing.Point(12, 23);
            this.ilaclarDataGrid.Name = "ilaclarDataGrid";
            this.ilaclarDataGrid.RowTemplate.Height = 25;
            this.ilaclarDataGrid.Size = new System.Drawing.Size(360, 282);
            this.ilaclarDataGrid.TabIndex = 0;
            // 
            // menuFrmBtn
            // 
            this.menuFrmBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuFrmBtn.Location = new System.Drawing.Point(387, 555);
            this.menuFrmBtn.Name = "menuFrmBtn";
            this.menuFrmBtn.Size = new System.Drawing.Size(97, 50);
            this.menuFrmBtn.TabIndex = 1;
            this.menuFrmBtn.Text = "Menüye Dön";
            this.menuFrmBtn.UseVisualStyleBackColor = false;
            this.menuFrmBtn.Click += new System.EventHandler(this.menuFrmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlaç Barkod No";
            // 
            // ilacBarkodTxt
            // 
            this.ilacBarkodTxt.Location = new System.Drawing.Point(119, 24);
            this.ilacBarkodTxt.Name = "ilacBarkodTxt";
            this.ilacBarkodTxt.Size = new System.Drawing.Size(118, 23);
            this.ilacBarkodTxt.TabIndex = 4;
            this.ilacBarkodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ilacBarkodTxt_KeyPress);
            // 
            // ilacAdTxt
            // 
            this.ilacAdTxt.Location = new System.Drawing.Point(131, 370);
            this.ilacAdTxt.Name = "ilacAdTxt";
            this.ilacAdTxt.Size = new System.Drawing.Size(118, 23);
            this.ilacAdTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlaç Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "İlaç Tipi";
            // 
            // ilacTipBox
            // 
            this.ilacTipBox.FormattingEnabled = true;
            this.ilacTipBox.Items.AddRange(new object[] {
            "Tablet",
            "Draje",
            "Şurup",
            "Ampül",
            "Krem",
            "Toz",
            "Damla"});
            this.ilacTipBox.Location = new System.Drawing.Point(128, 414);
            this.ilacTipBox.Name = "ilacTipBox";
            this.ilacTipBox.Size = new System.Drawing.Size(121, 23);
            this.ilacTipBox.TabIndex = 8;
            // 
            // ilacKaydetBtn
            // 
            this.ilacKaydetBtn.Location = new System.Drawing.Point(264, 51);
            this.ilacKaydetBtn.Name = "ilacKaydetBtn";
            this.ilacKaydetBtn.Size = new System.Drawing.Size(85, 46);
            this.ilacKaydetBtn.TabIndex = 9;
            this.ilacKaydetBtn.Text = "İlacı Kaydet";
            this.ilacKaydetBtn.UseVisualStyleBackColor = true;
            this.ilacKaydetBtn.Click += new System.EventHandler(this.ilacKaydetBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ilacSilBtn);
            this.groupBox1.Controls.Add(this.silinecekIlacBarkodTxt);
            this.groupBox1.Location = new System.Drawing.Point(13, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 68);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkodla İlaç Sil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "İlaç Barkodu";
            // 
            // ilacSilBtn
            // 
            this.ilacSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.ilacSilBtn.Location = new System.Drawing.Point(263, 21);
            this.ilacSilBtn.Name = "ilacSilBtn";
            this.ilacSilBtn.Size = new System.Drawing.Size(76, 36);
            this.ilacSilBtn.TabIndex = 23;
            this.ilacSilBtn.Text = "Sil";
            this.ilacSilBtn.UseVisualStyleBackColor = false;
            this.ilacSilBtn.Click += new System.EventHandler(this.ilacSilBtn_Click);
            // 
            // silinecekIlacBarkodTxt
            // 
            this.silinecekIlacBarkodTxt.Location = new System.Drawing.Point(84, 29);
            this.silinecekIlacBarkodTxt.Name = "silinecekIlacBarkodTxt";
            this.silinecekIlacBarkodTxt.Size = new System.Drawing.Size(132, 23);
            this.silinecekIlacBarkodTxt.TabIndex = 23;
            this.silinecekIlacBarkodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.silinecekIlacBarkodTxt_KeyPress);
            // 
            // ilacListeleBtn
            // 
            this.ilacListeleBtn.Location = new System.Drawing.Point(275, 557);
            this.ilacListeleBtn.Name = "ilacListeleBtn";
            this.ilacListeleBtn.Size = new System.Drawing.Size(97, 48);
            this.ilacListeleBtn.TabIndex = 24;
            this.ilacListeleBtn.Text = "İlaçları Listele";
            this.ilacListeleBtn.UseVisualStyleBackColor = true;
            this.ilacListeleBtn.Click += new System.EventHandler(this.ilacListeleBtn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ilacKaydetBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ilacBarkodTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 162);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlaç Kaydı";
            // 
            // hastalarDataGrid
            // 
            this.hastalarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalarDataGrid.Location = new System.Drawing.Point(400, 23);
            this.hastalarDataGrid.Name = "hastalarDataGrid";
            this.hastalarDataGrid.RowTemplate.Height = 25;
            this.hastalarDataGrid.Size = new System.Drawing.Size(440, 330);
            this.hastalarDataGrid.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.barkodAratBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.hastaBulTxt);
            this.groupBox3.Location = new System.Drawing.Point(387, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 547);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç Adıyla Hasta Sorgula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Büyük ve Küçük Harf Duyarlı Bir Aramadır, Lütfen İlacın İsmine Dikkat Ediniz.";
            // 
            // barkodAratBtn
            // 
            this.barkodAratBtn.Location = new System.Drawing.Point(257, 371);
            this.barkodAratBtn.Name = "barkodAratBtn";
            this.barkodAratBtn.Size = new System.Drawing.Size(134, 36);
            this.barkodAratBtn.TabIndex = 24;
            this.barkodAratBtn.Text = "Hastaları Listele";
            this.barkodAratBtn.UseVisualStyleBackColor = true;
            this.barkodAratBtn.Click += new System.EventHandler(this.barkodAratBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "İlaç Adı";
            // 
            // hastaBulTxt
            // 
            this.hastaBulTxt.Location = new System.Drawing.Point(86, 378);
            this.hastaBulTxt.Name = "hastaBulTxt";
            this.hastaBulTxt.Size = new System.Drawing.Size(151, 23);
            this.hastaBulTxt.TabIndex = 0;
            // 
            // IlacEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 628);
            this.Controls.Add(this.hastalarDataGrid);
            this.Controls.Add(this.ilacListeleBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ilacTipBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilacAdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuFrmBtn);
            this.Controls.Add(this.ilaclarDataGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IlacEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Ekranı";
            this.Load += new System.EventHandler(this.IlacEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ilaclarDataGrid;
        private Button menuFrmBtn;
        private Label label1;
        private TextBox ilacBarkodTxt;
        private TextBox ilacAdTxt;
        private Label label2;
        private Label label3;
        private ComboBox ilacTipBox;
        private Button ilacKaydetBtn;
        private GroupBox groupBox1;
        private Label label10;
        private Button ilacSilBtn;
        private TextBox silinecekIlacBarkodTxt;
        private Button ilacListeleBtn;
        private GroupBox groupBox2;
        private DataGridView hastalarDataGrid;
        private GroupBox groupBox3;
        private Button barkodAratBtn;
        private Label label4;
        private TextBox hastaBulTxt;
        private Label label5;
    }
}