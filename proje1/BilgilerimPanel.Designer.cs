namespace proje1
{
	partial class BilgilerimPanel
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

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary> 
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lbl_ad = new System.Windows.Forms.Label();
			this.lbl_İsimKayıt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_EPostaKayıt = new System.Windows.Forms.TextBox();
			this.lbl_SoyİsimKayıt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_TelNoKayıt = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.lbl_ad);
			this.panel2.Controls.Add(this.lbl_İsimKayıt);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lbl_EPostaKayıt);
			this.panel2.Controls.Add(this.lbl_SoyİsimKayıt);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.lbl_TelNoKayıt);
			this.panel2.Location = new System.Drawing.Point(382, 30);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(753, 616);
			this.panel2.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(90, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(271, 37);
			this.label3.TabIndex = 7;
			this.label3.Text = "Telefon Numarası";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(498, 402);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(189, 81);
			this.button1.TabIndex = 11;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_ad
			// 
			this.lbl_ad.AutoSize = true;
			this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_ad.Location = new System.Drawing.Point(90, 39);
			this.lbl_ad.Name = "lbl_ad";
			this.lbl_ad.Size = new System.Drawing.Size(75, 37);
			this.lbl_ad.TabIndex = 3;
			this.lbl_ad.Text = "İsim";
			// 
			// lbl_İsimKayıt
			// 
			this.lbl_İsimKayıt.Location = new System.Drawing.Point(404, 39);
			this.lbl_İsimKayıt.Multiline = true;
			this.lbl_İsimKayıt.Name = "lbl_İsimKayıt";
			this.lbl_İsimKayıt.Size = new System.Drawing.Size(219, 35);
			this.lbl_İsimKayıt.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(90, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 37);
			this.label1.TabIndex = 5;
			this.label1.Text = "Soyisim";
			// 
			// lbl_EPostaKayıt
			// 
			this.lbl_EPostaKayıt.Location = new System.Drawing.Point(404, 294);
			this.lbl_EPostaKayıt.Multiline = true;
			this.lbl_EPostaKayıt.Name = "lbl_EPostaKayıt";
			this.lbl_EPostaKayıt.Size = new System.Drawing.Size(219, 35);
			this.lbl_EPostaKayıt.TabIndex = 10;
			// 
			// lbl_SoyİsimKayıt
			// 
			this.lbl_SoyİsimKayıt.Location = new System.Drawing.Point(404, 123);
			this.lbl_SoyİsimKayıt.Multiline = true;
			this.lbl_SoyİsimKayıt.Name = "lbl_SoyİsimKayıt";
			this.lbl_SoyİsimKayıt.Size = new System.Drawing.Size(219, 35);
			this.lbl_SoyİsimKayıt.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(90, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 37);
			this.label4.TabIndex = 9;
			this.label4.Text = "E-Posta";
			// 
			// lbl_TelNoKayıt
			// 
			this.lbl_TelNoKayıt.Location = new System.Drawing.Point(404, 209);
			this.lbl_TelNoKayıt.Multiline = true;
			this.lbl_TelNoKayıt.Name = "lbl_TelNoKayıt";
			this.lbl_TelNoKayıt.Size = new System.Drawing.Size(219, 35);
			this.lbl_TelNoKayıt.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(3, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1605, 890);
			this.panel1.TabIndex = 16;
			// 
			// BilgilerimPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.panel1);
			this.Name = "BilgilerimPanel";
			this.Size = new System.Drawing.Size(2000, 2000);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbl_ad;
		private System.Windows.Forms.TextBox lbl_İsimKayıt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox lbl_EPostaKayıt;
		private System.Windows.Forms.TextBox lbl_SoyİsimKayıt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lbl_TelNoKayıt;
		private System.Windows.Forms.Panel panel1;
	}
}
