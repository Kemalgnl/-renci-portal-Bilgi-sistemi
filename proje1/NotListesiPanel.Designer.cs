namespace proje1
{
	partial class NotListesiPanel
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.VeriGösterici = new System.Windows.Forms.DataGridView();
			this.DönemGetir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SınıfDönemSeç = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VeriGösterici)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 108);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1664, 46);
			this.panel1.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(954, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 37);
			this.label9.TabIndex = 107;
			this.label9.Text = "Büt";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(841, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 37);
			this.label8.TabIndex = 106;
			this.label8.Text = "Final";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(1414, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 37);
			this.label10.TabIndex = 9;
			this.label10.Text = "Sonuç";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(741, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 37);
			this.label2.TabIndex = 10;
			this.label2.Text = "Vize";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(1273, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 37);
			this.label7.TabIndex = 8;
			this.label7.Text = "Not";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(1107, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 37);
			this.label6.TabIndex = 7;
			this.label6.Text = "Ort";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(537, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 37);
			this.label4.TabIndex = 5;
			this.label4.Text = "Durum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(162, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 37);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ders";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(785, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(199, 37);
			this.label5.TabIndex = 6;
			this.label5.Text = "Sınav Notları";
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoScrollMinSize = new System.Drawing.Size(15, 15);
			this.panel2.Controls.Add(this.VeriGösterici);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.DönemGetir);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.SınıfDönemSeç);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1577, 890);
			this.panel2.TabIndex = 10;
			// 
			// VeriGösterici
			// 
			this.VeriGösterici.BackgroundColor = System.Drawing.Color.White;
			this.VeriGösterici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.VeriGösterici.Location = new System.Drawing.Point(24, 169);
			this.VeriGösterici.Name = "VeriGösterici";
			this.VeriGösterici.RowHeadersWidth = 47;
			this.VeriGösterici.Size = new System.Drawing.Size(1533, 445);
			this.VeriGösterici.TabIndex = 105;
			// 
			// DönemGetir
			// 
			this.DönemGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DönemGetir.Location = new System.Drawing.Point(577, 32);
			this.DönemGetir.Name = "DönemGetir";
			this.DönemGetir.Size = new System.Drawing.Size(98, 44);
			this.DönemGetir.TabIndex = 104;
			this.DönemGetir.Text = "getir";
			this.DönemGetir.UseVisualStyleBackColor = true;
			this.DönemGetir.Click += new System.EventHandler(this.DönemGetir_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(35, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 32);
			this.label1.TabIndex = 86;
			this.label1.Text = "Sınıf Seçin";
			// 
			// SınıfDönemSeç
			// 
			this.SınıfDönemSeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SınıfDönemSeç.FormattingEnabled = true;
			this.SınıfDönemSeç.Items.AddRange(new object[] {
            "1.Sınıf  Güz    Dönemi",
            "1.Sınıf  Bahar Dönemi",
            "2.Sınıf  Güz    Dönemi",
            "2.Sınıf  Bahar Dönemi",
            "3.Sınıf  Güz    Dönemi",
            "3.Sınıf  Bahar Dönemi",
            "4.Sınıf  Güz    Dönemi",
            "4.Sınıf  Bahar Dönemi"});
			this.SınıfDönemSeç.Location = new System.Drawing.Point(213, 36);
			this.SınıfDönemSeç.Name = "SınıfDönemSeç";
			this.SınıfDönemSeç.Size = new System.Drawing.Size(343, 40);
			this.SınıfDönemSeç.TabIndex = 85;
			this.SınıfDönemSeç.SelectedIndexChanged += new System.EventHandler(this.SınıfDönemSeç_SelectedIndexChanged_1);
			// 
			// NotListesiPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.panel2);
			this.Name = "NotListesiPanel";
			this.Size = new System.Drawing.Size(2000, 2000);
			this.Load += new System.EventHandler(this.NotListesiPanel_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VeriGösterici)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox SınıfDönemSeç;
		private System.Windows.Forms.Button DönemGetir;
		private System.Windows.Forms.DataGridView VeriGösterici;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
	}
}
