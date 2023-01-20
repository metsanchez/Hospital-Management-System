namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.hastaFrmBttn = new System.Windows.Forms.Button();
            this.muayeneFrmBtn = new System.Windows.Forms.Button();
            this.gecmisMuayeneFrmBtn = new System.Windows.Forms.Button();
            this.ilacFrmBtn = new System.Windows.Forms.Button();
            this.receteFrmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÜ";
            // 
            // hastaFrmBttn
            // 
            this.hastaFrmBttn.Location = new System.Drawing.Point(183, 71);
            this.hastaFrmBttn.Name = "hastaFrmBttn";
            this.hastaFrmBttn.Size = new System.Drawing.Size(131, 51);
            this.hastaFrmBttn.TabIndex = 1;
            this.hastaFrmBttn.Text = "Hasta İşlemleri";
            this.hastaFrmBttn.UseVisualStyleBackColor = true;
            this.hastaFrmBttn.Click += new System.EventHandler(this.hastaFrmBttn_Click);
            // 
            // muayeneFrmBtn
            // 
            this.muayeneFrmBtn.Location = new System.Drawing.Point(183, 128);
            this.muayeneFrmBtn.Name = "muayeneFrmBtn";
            this.muayeneFrmBtn.Size = new System.Drawing.Size(131, 51);
            this.muayeneFrmBtn.TabIndex = 3;
            this.muayeneFrmBtn.Text = "Muayene Ekranı";
            this.muayeneFrmBtn.UseVisualStyleBackColor = true;
            this.muayeneFrmBtn.Click += new System.EventHandler(this.muayeneFrmBtn_Click);
            // 
            // gecmisMuayeneFrmBtn
            // 
            this.gecmisMuayeneFrmBtn.Location = new System.Drawing.Point(183, 185);
            this.gecmisMuayeneFrmBtn.Name = "gecmisMuayeneFrmBtn";
            this.gecmisMuayeneFrmBtn.Size = new System.Drawing.Size(131, 51);
            this.gecmisMuayeneFrmBtn.TabIndex = 4;
            this.gecmisMuayeneFrmBtn.Text = "Geçmiş Muayneler";
            this.gecmisMuayeneFrmBtn.UseVisualStyleBackColor = true;
            this.gecmisMuayeneFrmBtn.Click += new System.EventHandler(this.gecmisMuayeneFrmBtn_Click);
            // 
            // ilacFrmBtn
            // 
            this.ilacFrmBtn.Location = new System.Drawing.Point(183, 242);
            this.ilacFrmBtn.Name = "ilacFrmBtn";
            this.ilacFrmBtn.Size = new System.Drawing.Size(131, 51);
            this.ilacFrmBtn.TabIndex = 5;
            this.ilacFrmBtn.Text = "İlaç Ekranı";
            this.ilacFrmBtn.UseVisualStyleBackColor = true;
            this.ilacFrmBtn.Click += new System.EventHandler(this.ilacFrmBtn_Click);
            // 
            // receteFrmBtn
            // 
            this.receteFrmBtn.Location = new System.Drawing.Point(183, 299);
            this.receteFrmBtn.Name = "receteFrmBtn";
            this.receteFrmBtn.Size = new System.Drawing.Size(131, 51);
            this.receteFrmBtn.TabIndex = 7;
            this.receteFrmBtn.Text = "Reçete Ekranı";
            this.receteFrmBtn.UseVisualStyleBackColor = true;
            this.receteFrmBtn.Click += new System.EventHandler(this.receteFrmBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 414);
            this.Controls.Add(this.receteFrmBtn);
            this.Controls.Add(this.ilacFrmBtn);
            this.Controls.Add(this.gecmisMuayeneFrmBtn);
            this.Controls.Add(this.muayeneFrmBtn);
            this.Controls.Add(this.hastaFrmBttn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Bilgi Yönetim Sistemi(MBYS)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button hastaFrmBttn;
        private Button muayeneFrmBtn;
        private Button gecmisMuayeneFrmBtn;
        private Button ilacFrmBtn;
        private Button receteFrmBtn;
    }
}