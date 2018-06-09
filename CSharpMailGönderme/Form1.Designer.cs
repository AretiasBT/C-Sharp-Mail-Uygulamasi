namespace CSharpMailGönderme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMailGonder = new System.Windows.Forms.Label();
            this.lblKimden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.txtGizli = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.richTxtEkle = new System.Windows.Forms.RichTextBox();
            this.btnEkler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMailGonder
            // 
            this.lblMailGonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMailGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailGonder.Location = new System.Drawing.Point(10, 12);
            this.lblMailGonder.Name = "lblMailGonder";
            this.lblMailGonder.Size = new System.Drawing.Size(333, 28);
            this.lblMailGonder.TabIndex = 0;
            this.lblMailGonder.Text = "C# MAİL UYGULAMASI";
            this.lblMailGonder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKimden
            // 
            this.lblKimden.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKimden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKimden.Location = new System.Drawing.Point(10, 43);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(88, 22);
            this.lblKimden.TabIndex = 1;
            this.lblKimden.Text = "Alıcı";
            this.lblKimden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilgi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlici
            // 
            this.txtAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlici.Location = new System.Drawing.Point(104, 43);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(239, 22);
            this.txtAlici.TabIndex = 3;
            // 
            // txtBilgi
            // 
            this.txtBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi.Location = new System.Drawing.Point(104, 69);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(239, 22);
            this.txtBilgi.TabIndex = 4;
            // 
            // txtGizli
            // 
            this.txtGizli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGizli.Location = new System.Drawing.Point(104, 95);
            this.txtGizli.Name = "txtGizli";
            this.txtGizli.Size = new System.Drawing.Size(239, 22);
            this.txtGizli.TabIndex = 5;
            // 
            // txtKonu
            // 
            this.txtKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(104, 121);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(239, 22);
            this.txtKonu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gizli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Konu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.Location = new System.Drawing.Point(10, 182);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(333, 114);
            this.txtIcerik.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mesaj İçeriği";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(8, 361);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(333, 32);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // richTxtEkle
            // 
            this.richTxtEkle.Location = new System.Drawing.Point(74, 302);
            this.richTxtEkle.Name = "richTxtEkle";
            this.richTxtEkle.ReadOnly = true;
            this.richTxtEkle.Size = new System.Drawing.Size(267, 53);
            this.richTxtEkle.TabIndex = 14;
            this.richTxtEkle.Text = "";
            // 
            // btnEkler
            // 
            this.btnEkler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkler.Location = new System.Drawing.Point(10, 302);
            this.btnEkler.Name = "btnEkler";
            this.btnEkler.Size = new System.Drawing.Size(58, 53);
            this.btnEkler.TabIndex = 15;
            this.btnEkler.Text = "Dosya Ekle";
            this.btnEkler.UseVisualStyleBackColor = true;
            this.btnEkler.Click += new System.EventHandler(this.btnEkler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 404);
            this.Controls.Add(this.btnEkler);
            this.Controls.Add(this.richTxtEkle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtGizli);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKimden);
            this.Controls.Add(this.lblMailGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailGonder;
        private System.Windows.Forms.Label lblKimden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.TextBox txtGizli;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.RichTextBox richTxtEkle;
        private System.Windows.Forms.Button btnEkler;
    }
}

