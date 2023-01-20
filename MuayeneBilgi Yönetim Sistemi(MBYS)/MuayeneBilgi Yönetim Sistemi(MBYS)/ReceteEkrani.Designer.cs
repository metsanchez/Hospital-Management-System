namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    partial class ReceteEkrani
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
            this.receteDataGrid = new System.Windows.Forms.DataGridView();
            this.receteListeleBtn = new System.Windows.Forms.Button();
            this.menuFrmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receteBulBtn = new System.Windows.Forms.Button();
            this.hastaTcTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receteSilBtn = new System.Windows.Forms.Button();
            this.receteSilTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receteNoListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.receteDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // receteDataGrid
            // 
            this.receteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteDataGrid.Location = new System.Drawing.Point(12, 12);
            this.receteDataGrid.Name = "receteDataGrid";
            this.receteDataGrid.RowTemplate.Height = 25;
            this.receteDataGrid.Size = new System.Drawing.Size(653, 264);
            this.receteDataGrid.TabIndex = 0;
            // 
            // receteListeleBtn
            // 
            this.receteListeleBtn.Location = new System.Drawing.Point(25, 291);
            this.receteListeleBtn.Name = "receteListeleBtn";
            this.receteListeleBtn.Size = new System.Drawing.Size(135, 45);
            this.receteListeleBtn.TabIndex = 1;
            this.receteListeleBtn.Text = "Reçeteleri Tarihe Göre Listele";
            this.receteListeleBtn.UseVisualStyleBackColor = true;
            this.receteListeleBtn.Click += new System.EventHandler(this.receteListeleBtn_Click);
            // 
            // menuFrmBtn
            // 
            this.menuFrmBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuFrmBtn.Location = new System.Drawing.Point(25, 398);
            this.menuFrmBtn.Name = "menuFrmBtn";
            this.menuFrmBtn.Size = new System.Drawing.Size(135, 47);
            this.menuFrmBtn.TabIndex = 2;
            this.menuFrmBtn.Text = "Menüye Dön";
            this.menuFrmBtn.UseVisualStyleBackColor = false;
            this.menuFrmBtn.Click += new System.EventHandler(this.menuFrmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receteBulBtn);
            this.groupBox1.Controls.Add(this.hastaTcTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastanın Reçeteleri";
            // 
            // receteBulBtn
            // 
            this.receteBulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receteBulBtn.Location = new System.Drawing.Point(303, 22);
            this.receteBulBtn.Name = "receteBulBtn";
            this.receteBulBtn.Size = new System.Drawing.Size(135, 47);
            this.receteBulBtn.TabIndex = 4;
            this.receteBulBtn.Text = "Reçeteleri Gör";
            this.receteBulBtn.UseVisualStyleBackColor = true;
            this.receteBulBtn.Click += new System.EventHandler(this.receteBulBtn_Click);
            // 
            // hastaTcTxt
            // 
            this.hastaTcTxt.Location = new System.Drawing.Point(126, 35);
            this.hastaTcTxt.Name = "hastaTcTxt";
            this.hastaTcTxt.Size = new System.Drawing.Size(134, 23);
            this.hastaTcTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Tc No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receteSilBtn);
            this.groupBox2.Controls.Add(this.receteSilTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(197, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reçete Sil";
            // 
            // receteSilBtn
            // 
            this.receteSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.receteSilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receteSilBtn.Location = new System.Drawing.Point(303, 17);
            this.receteSilBtn.Name = "receteSilBtn";
            this.receteSilBtn.Size = new System.Drawing.Size(135, 47);
            this.receteSilBtn.TabIndex = 7;
            this.receteSilBtn.Text = "Sil";
            this.receteSilBtn.UseVisualStyleBackColor = false;
            this.receteSilBtn.Click += new System.EventHandler(this.receteSilBtn_Click);
            // 
            // receteSilTxt
            // 
            this.receteSilTxt.Location = new System.Drawing.Point(126, 30);
            this.receteSilTxt.Name = "receteSilTxt";
            this.receteSilTxt.Size = new System.Drawing.Size(134, 23);
            this.receteSilTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reçete No";
            // 
            // receteNoListBtn
            // 
            this.receteNoListBtn.Location = new System.Drawing.Point(25, 347);
            this.receteNoListBtn.Name = "receteNoListBtn";
            this.receteNoListBtn.Size = new System.Drawing.Size(135, 45);
            this.receteNoListBtn.TabIndex = 5;
            this.receteNoListBtn.Text = "Reçeteleri No\'ya Göre Listele";
            this.receteNoListBtn.UseVisualStyleBackColor = true;
            this.receteNoListBtn.Click += new System.EventHandler(this.receteNoListBtn_Click);
            // 
            // ReceteEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 463);
            this.Controls.Add(this.receteNoListBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuFrmBtn);
            this.Controls.Add(this.receteListeleBtn);
            this.Controls.Add(this.receteDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceteEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceteEkrani";
            this.Load += new System.EventHandler(this.ReceteEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receteDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView receteDataGrid;
        private Button receteListeleBtn;
        private Button menuFrmBtn;
        private GroupBox groupBox1;
        private Button receteBulBtn;
        private TextBox hastaTcTxt;
        private Label label1;
        private GroupBox groupBox2;
        private Button receteSilBtn;
        private TextBox receteSilTxt;
        private Label label2;
        private Button receteNoListBtn;
    }
}