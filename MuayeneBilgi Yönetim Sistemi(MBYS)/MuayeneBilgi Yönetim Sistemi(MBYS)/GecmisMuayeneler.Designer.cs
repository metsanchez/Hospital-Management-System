namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    partial class GecmisMuayeneler
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
            this.muayenelerDataGrid = new System.Windows.Forms.DataGridView();
            this.menuFrmBtn = new System.Windows.Forms.Button();
            this.muayeneListeleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.silTcTxt = new System.Windows.Forms.TextBox();
            this.muayeneSilBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.silTarihTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.muayenelerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // muayenelerDataGrid
            // 
            this.muayenelerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayenelerDataGrid.Location = new System.Drawing.Point(21, 46);
            this.muayenelerDataGrid.Name = "muayenelerDataGrid";
            this.muayenelerDataGrid.RowTemplate.Height = 25;
            this.muayenelerDataGrid.Size = new System.Drawing.Size(1004, 368);
            this.muayenelerDataGrid.TabIndex = 0;
            // 
            // menuFrmBtn
            // 
            this.menuFrmBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuFrmBtn.Location = new System.Drawing.Point(21, 476);
            this.menuFrmBtn.Name = "menuFrmBtn";
            this.menuFrmBtn.Size = new System.Drawing.Size(150, 45);
            this.menuFrmBtn.TabIndex = 1;
            this.menuFrmBtn.Text = "Menüye Dön";
            this.menuFrmBtn.UseVisualStyleBackColor = false;
            this.menuFrmBtn.Click += new System.EventHandler(this.menuFrmBtn_Click);
            // 
            // muayeneListeleBtn
            // 
            this.muayeneListeleBtn.Location = new System.Drawing.Point(21, 420);
            this.muayeneListeleBtn.Name = "muayeneListeleBtn";
            this.muayeneListeleBtn.Size = new System.Drawing.Size(150, 45);
            this.muayeneListeleBtn.TabIndex = 2;
            this.muayeneListeleBtn.Text = "Muayeneleri Listele";
            this.muayeneListeleBtn.UseVisualStyleBackColor = true;
            this.muayeneListeleBtn.Click += new System.EventHandler(this.muayeneListeleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geçmiş Muayeneler";
            // 
            // silTcTxt
            // 
            this.silTcTxt.Location = new System.Drawing.Point(746, 437);
            this.silTcTxt.Name = "silTcTxt";
            this.silTcTxt.Size = new System.Drawing.Size(128, 23);
            this.silTcTxt.TabIndex = 4;
            // 
            // muayeneSilBtn
            // 
            this.muayeneSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.muayeneSilBtn.Location = new System.Drawing.Point(893, 453);
            this.muayeneSilBtn.Name = "muayeneSilBtn";
            this.muayeneSilBtn.Size = new System.Drawing.Size(132, 43);
            this.muayeneSilBtn.TabIndex = 5;
            this.muayeneSilBtn.Text = "Muayene Sil";
            this.muayeneSilBtn.UseVisualStyleBackColor = false;
            this.muayeneSilBtn.Click += new System.EventHandler(this.muayeneSilBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta Tc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Muayene Tarihi";
            // 
            // silTarihTxt
            // 
            this.silTarihTxt.Location = new System.Drawing.Point(746, 478);
            this.silTarihTxt.Name = "silTarihTxt";
            this.silTarihTxt.Size = new System.Drawing.Size(128, 23);
            this.silTarihTxt.TabIndex = 8;
            // 
            // GecmisMuayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 562);
            this.Controls.Add(this.silTarihTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.muayeneSilBtn);
            this.Controls.Add(this.silTcTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muayeneListeleBtn);
            this.Controls.Add(this.menuFrmBtn);
            this.Controls.Add(this.muayenelerDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GecmisMuayeneler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GecmisMuayeneler";
            this.Load += new System.EventHandler(this.GecmisMuayeneler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muayenelerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView muayenelerDataGrid;
        private Button menuFrmBtn;
        private Button muayeneListeleBtn;
        private Label label1;
        private TextBox silTcTxt;
        private Button muayeneSilBtn;
        private Label label2;
        private Label label3;
        private TextBox silTarihTxt;
    }
}