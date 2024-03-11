namespace proje1
{
	partial class DersProgramıPanel
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.VeriGösterici4 = new System.Windows.Forms.DataGridView();
			this.label13 = new System.Windows.Forms.Label();
			this.DönemGetir = new System.Windows.Forms.Button();
			this.SınıfDönemSeç = new System.Windows.Forms.ComboBox();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VeriGösterici4)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.Controls.Add(this.VeriGösterici4);
			this.panel3.Location = new System.Drawing.Point(0, 96);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1606, 1055);
			this.panel3.TabIndex = 4;
			// 
			// VeriGösterici4
			// 
			this.VeriGösterici4.BackgroundColor = System.Drawing.SystemColors.Control;
			this.VeriGösterici4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.VeriGösterici4.Location = new System.Drawing.Point(3, 3);
			this.VeriGösterici4.Name = "VeriGösterici4";
			this.VeriGösterici4.RowHeadersWidth = 47;
			this.VeriGösterici4.Size = new System.Drawing.Size(1600, 890);
			this.VeriGösterici4.TabIndex = 106;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.Location = new System.Drawing.Point(50, 28);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(150, 32);
			this.label13.TabIndex = 88;
			this.label13.Text = "Sınıf Seçin";
			// 
			// DönemGetir
			// 
			this.DönemGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DönemGetir.Location = new System.Drawing.Point(576, 23);
			this.DönemGetir.Name = "DönemGetir";
			this.DönemGetir.Size = new System.Drawing.Size(104, 45);
			this.DönemGetir.TabIndex = 104;
			this.DönemGetir.Text = "getir";
			this.DönemGetir.UseVisualStyleBackColor = true;
			this.DönemGetir.Click += new System.EventHandler(this.DönemGetir_Click);
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
			this.SınıfDönemSeç.Location = new System.Drawing.Point(206, 28);
			this.SınıfDönemSeç.Name = "SınıfDönemSeç";
			this.SınıfDönemSeç.Size = new System.Drawing.Size(343, 40);
			this.SınıfDönemSeç.TabIndex = 86;
			this.SınıfDönemSeç.SelectedIndexChanged += new System.EventHandler(this.SınıfDönemSeç_SelectedIndexChanged);
			// 
			// DersProgramıPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.SınıfDönemSeç);
			this.Controls.Add(this.DönemGetir);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel3);
			this.Name = "DersProgramıPanel";
			this.Size = new System.Drawing.Size(2000, 2000);
			this.Load += new System.EventHandler(this.DersProgramıPanel_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VeriGösterici4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button DönemGetir;
		private System.Windows.Forms.ComboBox SınıfDönemSeç;
		private System.Windows.Forms.DataGridView VeriGösterici4;
	}
}
