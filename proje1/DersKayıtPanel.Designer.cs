namespace proje1
{
	partial class DersKayıtPanel
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Ders1_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders4_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders2_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders8_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders3_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders7_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders5_Ekle = new System.Windows.Forms.Button();
			this.btn_Ders6_Ekle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DönemGetir = new System.Windows.Forms.Button();
			this.label41 = new System.Windows.Forms.Label();
			this.SınıfDönemSeç = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label23 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.DönemGetir);
			this.panel2.Controls.Add(this.label41);
			this.panel2.Controls.Add(this.SınıfDönemSeç);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1616, 890);
			this.panel2.TabIndex = 13;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btn_Ders1_Ekle);
			this.panel1.Controls.Add(this.btn_Ders4_Ekle);
			this.panel1.Controls.Add(this.btn_Ders2_Ekle);
			this.panel1.Controls.Add(this.btn_Ders8_Ekle);
			this.panel1.Controls.Add(this.btn_Ders3_Ekle);
			this.panel1.Controls.Add(this.btn_Ders7_Ekle);
			this.panel1.Controls.Add(this.btn_Ders5_Ekle);
			this.panel1.Controls.Add(this.btn_Ders6_Ekle);
			this.panel1.Location = new System.Drawing.Point(1041, 154);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 432);
			this.panel1.TabIndex = 116;
			// 
			// btn_Ders1_Ekle
			// 
			this.btn_Ders1_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders1_Ekle.Location = new System.Drawing.Point(0, 0);
			this.btn_Ders1_Ekle.Name = "btn_Ders1_Ekle";
			this.btn_Ders1_Ekle.Size = new System.Drawing.Size(181, 54);
			this.btn_Ders1_Ekle.TabIndex = 12;
			this.btn_Ders1_Ekle.Text = "Kaydet";
			this.btn_Ders1_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders1_Ekle.Click += new System.EventHandler(this.btn_Ders1_Ekle_Click);
			// 
			// btn_Ders4_Ekle
			// 
			this.btn_Ders4_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders4_Ekle.Location = new System.Drawing.Point(0, 164);
			this.btn_Ders4_Ekle.Name = "btn_Ders4_Ekle";
			this.btn_Ders4_Ekle.Size = new System.Drawing.Size(181, 54);
			this.btn_Ders4_Ekle.TabIndex = 87;
			this.btn_Ders4_Ekle.Text = "Kaydet";
			this.btn_Ders4_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders4_Ekle.Click += new System.EventHandler(this.btn_Ders4_Ekle_Click);
			// 
			// btn_Ders2_Ekle
			// 
			this.btn_Ders2_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders2_Ekle.Location = new System.Drawing.Point(0, 54);
			this.btn_Ders2_Ekle.Name = "btn_Ders2_Ekle";
			this.btn_Ders2_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders2_Ekle.TabIndex = 85;
			this.btn_Ders2_Ekle.Text = "Kaydet";
			this.btn_Ders2_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders2_Ekle.Click += new System.EventHandler(this.btn_Ders2_Ekle_Click);
			// 
			// btn_Ders8_Ekle
			// 
			this.btn_Ders8_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders8_Ekle.Location = new System.Drawing.Point(-1, 388);
			this.btn_Ders8_Ekle.Name = "btn_Ders8_Ekle";
			this.btn_Ders8_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders8_Ekle.TabIndex = 91;
			this.btn_Ders8_Ekle.Text = "Kaydet";
			this.btn_Ders8_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders8_Ekle.Click += new System.EventHandler(this.btn_Ders8_Ekle_Click);
			// 
			// btn_Ders3_Ekle
			// 
			this.btn_Ders3_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders3_Ekle.Location = new System.Drawing.Point(-1, 109);
			this.btn_Ders3_Ekle.Name = "btn_Ders3_Ekle";
			this.btn_Ders3_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders3_Ekle.TabIndex = 86;
			this.btn_Ders3_Ekle.Text = "Kaydet";
			this.btn_Ders3_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders3_Ekle.Click += new System.EventHandler(this.btn_Ders3_Ekle_Click);
			// 
			// btn_Ders7_Ekle
			// 
			this.btn_Ders7_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders7_Ekle.Location = new System.Drawing.Point(-1, 332);
			this.btn_Ders7_Ekle.Name = "btn_Ders7_Ekle";
			this.btn_Ders7_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders7_Ekle.TabIndex = 90;
			this.btn_Ders7_Ekle.Text = "Kaydet";
			this.btn_Ders7_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders7_Ekle.Click += new System.EventHandler(this.btn_Ders7_Ekle_Click);
			// 
			// btn_Ders5_Ekle
			// 
			this.btn_Ders5_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders5_Ekle.Location = new System.Drawing.Point(-1, 220);
			this.btn_Ders5_Ekle.Name = "btn_Ders5_Ekle";
			this.btn_Ders5_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders5_Ekle.TabIndex = 88;
			this.btn_Ders5_Ekle.Text = "Kaydet";
			this.btn_Ders5_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders5_Ekle.Click += new System.EventHandler(this.btn_Ders5_Ekle_Click);
			// 
			// btn_Ders6_Ekle
			// 
			this.btn_Ders6_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders6_Ekle.Location = new System.Drawing.Point(-1, 276);
			this.btn_Ders6_Ekle.Name = "btn_Ders6_Ekle";
			this.btn_Ders6_Ekle.Size = new System.Drawing.Size(180, 54);
			this.btn_Ders6_Ekle.TabIndex = 89;
			this.btn_Ders6_Ekle.Text = "Kaydet";
			this.btn_Ders6_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ders6_Ekle.Click += new System.EventHandler(this.btn_Ders6_Ekle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(91, 154);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 47;
			this.dataGridView1.Size = new System.Drawing.Size(1130, 445);
			this.dataGridView1.TabIndex = 104;
			// 
			// DönemGetir
			// 
			this.DönemGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DönemGetir.Location = new System.Drawing.Point(575, 32);
			this.DönemGetir.Name = "DönemGetir";
			this.DönemGetir.Size = new System.Drawing.Size(176, 40);
			this.DönemGetir.TabIndex = 103;
			this.DönemGetir.Text = "getir";
			this.DönemGetir.UseVisualStyleBackColor = true;
			this.DönemGetir.Click += new System.EventHandler(this.DönemGetir_Click);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.16216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label41.Location = new System.Drawing.Point(31, 32);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(150, 32);
			this.label41.TabIndex = 84;
			this.label41.Text = "Sınıf Seçin";
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
			this.SınıfDönemSeç.Location = new System.Drawing.Point(209, 32);
			this.SınıfDönemSeç.Name = "SınıfDönemSeç";
			this.SınıfDönemSeç.Size = new System.Drawing.Size(343, 40);
			this.SınıfDönemSeç.TabIndex = 83;
			this.SınıfDönemSeç.SelectedIndexChanged += new System.EventHandler(this.SınıfDönemSeç_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(812, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ders Kayıt";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.AutoSize = true;
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Controls.Add(this.label23);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(0, 97);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1703, 46);
			this.panel3.TabIndex = 2;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label23.Location = new System.Drawing.Point(836, 6);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(101, 37);
			this.label23.TabIndex = 10;
			this.label23.Text = "AKTS";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(1079, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 37);
			this.label7.TabIndex = 8;
			this.label7.Text = "Ekle";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(684, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 37);
			this.label5.TabIndex = 6;
			this.label5.Text = "Kredi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.10811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(162, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 37);
			this.label8.TabIndex = 4;
			this.label8.Text = "Ders";
			// 
			// DersKayıtPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.panel2);
			this.Name = "DersKayıtPanel";
			this.Size = new System.Drawing.Size(2464, 2000);
			this.Load += new System.EventHandler(this.DersKayıtPanel_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_Ders8_Ekle;
		private System.Windows.Forms.Button btn_Ders7_Ekle;
		private System.Windows.Forms.Button btn_Ders6_Ekle;
		private System.Windows.Forms.Button btn_Ders5_Ekle;
		private System.Windows.Forms.Button btn_Ders4_Ekle;
		private System.Windows.Forms.Button btn_Ders3_Ekle;
		private System.Windows.Forms.Button btn_Ders2_Ekle;
		private System.Windows.Forms.Button btn_Ders1_Ekle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.ComboBox SınıfDönemSeç;
		private System.Windows.Forms.Button DönemGetir;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
	}
}
