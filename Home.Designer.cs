namespace HastaneOto
{
    partial class Home
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
            this.btnRandevuIslemleri = new System.Windows.Forms.Button();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandevuIslemleri
            // 
            this.btnRandevuIslemleri.Location = new System.Drawing.Point(100, 143);
            this.btnRandevuIslemleri.Name = "btnRandevuIslemleri";
            this.btnRandevuIslemleri.Size = new System.Drawing.Size(280, 81);
            this.btnRandevuIslemleri.TabIndex = 0;
            this.btnRandevuIslemleri.Text = "Randevu İşlemleri";
            this.btnRandevuIslemleri.UseVisualStyleBackColor = true;
            this.btnRandevuIslemleri.Click += new System.EventHandler(this.btnRandevuIslemleri_Click);
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Location = new System.Drawing.Point(100, 246);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(280, 80);
            this.btnHastaIslemleri.TabIndex = 1;
            this.btnHastaIslemleri.Text = "Hasta İşlemleri";
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            this.btnHastaIslemleri.Click += new System.EventHandler(this.btnHastaIslemleri_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(399, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(267, 81);
            this.button7.TabIndex = 6;
            this.button7.Text = "Yönetici Ayarları";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(399, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(267, 80);
            this.button8.TabIndex = 7;
            this.button8.Text = "Yardım";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hastane Otomasyonu - Ana menü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnHastaIslemleri);
            this.Controls.Add(this.btnRandevuIslemleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandevuIslemleri;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}

