namespace proje1
{
	partial class Portal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Btn_Bilgilerim = new System.Windows.Forms.Button();
			this.Btn_Çıkış = new System.Windows.Forms.Button();
			this.btn_Fotoğraf_Değiş = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.YanPanel = new System.Windows.Forms.Panel();
			this.btn_Ders_Kayıt = new System.Windows.Forms.Button();
			this.btn_Not_Listesi = new System.Windows.Forms.Button();
			this.btn_Transkript = new System.Windows.Forms.Button();
			this.btn_Ders_Programı = new System.Windows.Forms.Button();
			this.Profil_Resmi = new System.Windows.Forms.PictureBox();
			this.bilgilerimPanel1 = new proje1.BilgilerimPanel();
			this.dersProgramıPanel1 = new proje1.DersProgramıPanel();
			this.transkriptPanel1 = new proje1.TranskriptPanel();
			this.dersKayıtPanel1 = new proje1.DersKayıtPanel();
			this.notListesiPanel1 = new proje1.NotListesiPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Profil_Resmi)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btn_Fotoğraf_Değiş);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.Profil_Resmi);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(356, 835);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.Btn_Bilgilerim);
			this.panel2.Controls.Add(this.Btn_Çıkış);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 698);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(356, 137);
			this.panel2.TabIndex = 6;
			// 
			// Btn_Bilgilerim
			// 
			this.Btn_Bilgilerim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Bilgilerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_Bilgilerim.Location = new System.Drawing.Point(40, 20);
			this.Btn_Bilgilerim.Name = "Btn_Bilgilerim";
			this.Btn_Bilgilerim.Size = new System.Drawing.Size(262, 45);
			this.Btn_Bilgilerim.TabIndex = 5;
			this.Btn_Bilgilerim.Text = "Bilgilerim";
			this.Btn_Bilgilerim.UseVisualStyleBackColor = true;
			this.Btn_Bilgilerim.Click += new System.EventHandler(this.Btn_Bilgilerim_Click);
			// 
			// Btn_Çıkış
			// 
			this.Btn_Çıkış.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Çıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_Çıkış.Location = new System.Drawing.Point(40, 80);
			this.Btn_Çıkış.Name = "Btn_Çıkış";
			this.Btn_Çıkış.Size = new System.Drawing.Size(262, 45);
			this.Btn_Çıkış.TabIndex = 6;
			this.Btn_Çıkış.Text = "Çıkış";
			this.Btn_Çıkış.UseVisualStyleBackColor = true;
			this.Btn_Çıkış.Click += new System.EventHandler(this.Btn_Çıkış_Click);
			// 
			// btn_Fotoğraf_Değiş
			// 
			this.btn_Fotoğraf_Değiş.AutoSize = true;
			this.btn_Fotoğraf_Değiş.Location = new System.Drawing.Point(116, 169);
			this.btn_Fotoğraf_Değiş.Name = "btn_Fotoğraf_Değiş";
			this.btn_Fotoğraf_Değiş.Size = new System.Drawing.Size(123, 28);
			this.btn_Fotoğraf_Değiş.TabIndex = 8;
			this.btn_Fotoğraf_Değiş.Text = "Fotoğraf Değiştir";
			this.btn_Fotoğraf_Değiş.UseVisualStyleBackColor = true;
			this.btn_Fotoğraf_Değiş.Click += new System.EventHandler(this.btn_Fotoğraf_Değiş_Click);
			// 
			// panel6
			// 
			this.panel6.AutoSize = true;
			this.panel6.Controls.Add(this.YanPanel);
			this.panel6.Controls.Add(this.btn_Ders_Kayıt);
			this.panel6.Controls.Add(this.btn_Not_Listesi);
			this.panel6.Controls.Add(this.btn_Transkript);
			this.panel6.Controls.Add(this.btn_Ders_Programı);
			this.panel6.Location = new System.Drawing.Point(0, 250);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(356, 259);
			this.panel6.TabIndex = 2;
			// 
			// YanPanel
			// 
			this.YanPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.YanPanel.Location = new System.Drawing.Point(0, 18);
			this.YanPanel.Name = "YanPanel";
			this.YanPanel.Size = new System.Drawing.Size(29, 43);
			this.YanPanel.TabIndex = 3;
			// 
			// btn_Ders_Kayıt
			// 
			this.btn_Ders_Kayıt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Ders_Kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders_Kayıt.Location = new System.Drawing.Point(26, 18);
			this.btn_Ders_Kayıt.Name = "btn_Ders_Kayıt";
			this.btn_Ders_Kayıt.Size = new System.Drawing.Size(307, 43);
			this.btn_Ders_Kayıt.TabIndex = 1;
			this.btn_Ders_Kayıt.Text = "Ders Kayıt";
			this.btn_Ders_Kayıt.UseVisualStyleBackColor = true;
			this.btn_Ders_Kayıt.Click += new System.EventHandler(this.DersKayıt_Click);
			// 
			// btn_Not_Listesi
			// 
			this.btn_Not_Listesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Not_Listesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Not_Listesi.Location = new System.Drawing.Point(26, 74);
			this.btn_Not_Listesi.Name = "btn_Not_Listesi";
			this.btn_Not_Listesi.Size = new System.Drawing.Size(307, 43);
			this.btn_Not_Listesi.TabIndex = 2;
			this.btn_Not_Listesi.Text = "Not Listesi";
			this.btn_Not_Listesi.UseVisualStyleBackColor = true;
			this.btn_Not_Listesi.Click += new System.EventHandler(this.btn_Not_Listesi_Click);
			// 
			// btn_Transkript
			// 
			this.btn_Transkript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Transkript.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Transkript.Location = new System.Drawing.Point(26, 132);
			this.btn_Transkript.Name = "btn_Transkript";
			this.btn_Transkript.Size = new System.Drawing.Size(307, 43);
			this.btn_Transkript.TabIndex = 3;
			this.btn_Transkript.Text = "Transkript";
			this.btn_Transkript.UseVisualStyleBackColor = true;
			this.btn_Transkript.Click += new System.EventHandler(this.btn_Transkript_Click);
			// 
			// btn_Ders_Programı
			// 
			this.btn_Ders_Programı.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Ders_Programı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.91892F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Ders_Programı.Location = new System.Drawing.Point(26, 191);
			this.btn_Ders_Programı.Name = "btn_Ders_Programı";
			this.btn_Ders_Programı.Size = new System.Drawing.Size(307, 43);
			this.btn_Ders_Programı.TabIndex = 4;
			this.btn_Ders_Programı.Text = "Ders Programı";
			this.btn_Ders_Programı.UseVisualStyleBackColor = true;
			this.btn_Ders_Programı.Click += new System.EventHandler(this.btn_Ders_Programı_Click);
			// 
			// Profil_Resmi
			// 
			this.Profil_Resmi.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Profil_Resmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Profil_Resmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Profil_Resmi.Image = ((System.Drawing.Image)(resources.GetObject("Profil_Resmi.Image")));
			this.Profil_Resmi.Location = new System.Drawing.Point(85, 12);
			this.Profil_Resmi.Margin = new System.Windows.Forms.Padding(0);
			this.Profil_Resmi.Name = "Profil_Resmi";
			this.Profil_Resmi.Size = new System.Drawing.Size(175, 154);
			this.Profil_Resmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Profil_Resmi.TabIndex = 7;
			this.Profil_Resmi.TabStop = false;
			// 
			// bilgilerimPanel1
			// 
			this.bilgilerimPanel1.AutoSize = true;
			this.bilgilerimPanel1.Location = new System.Drawing.Point(352, 0);
			this.bilgilerimPanel1.Name = "bilgilerimPanel1";
			this.bilgilerimPanel1.Size = new System.Drawing.Size(1580, 820);
			this.bilgilerimPanel1.TabIndex = 5;
			// 
			// dersProgramıPanel1
			// 
			this.dersProgramıPanel1.AutoSize = true;
			this.dersProgramıPanel1.Location = new System.Drawing.Point(352, 0);
			this.dersProgramıPanel1.Name = "dersProgramıPanel1";
			this.dersProgramıPanel1.Size = new System.Drawing.Size(1606, 1271);
			this.dersProgramıPanel1.TabIndex = 4;
			// 
			// transkriptPanel1
			// 
			this.transkriptPanel1.AutoSize = true;
			this.transkriptPanel1.Location = new System.Drawing.Point(352, 0);
			this.transkriptPanel1.Name = "transkriptPanel1";
			this.transkriptPanel1.Size = new System.Drawing.Size(1580, 1023);
			this.transkriptPanel1.TabIndex = 3;
			// 
			// dersKayıtPanel1
			// 
			this.dersKayıtPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dersKayıtPanel1.AutoSize = true;
			this.dersKayıtPanel1.Location = new System.Drawing.Point(352, 0);
			this.dersKayıtPanel1.Name = "dersKayıtPanel1";
			this.dersKayıtPanel1.Size = new System.Drawing.Size(1619, 835);
			this.dersKayıtPanel1.TabIndex = 2;
			// 
			// notListesiPanel1
			// 
			this.notListesiPanel1.AutoSize = true;
			this.notListesiPanel1.Location = new System.Drawing.Point(352, -5);
			this.notListesiPanel1.Name = "notListesiPanel1";
			this.notListesiPanel1.Size = new System.Drawing.Size(1580, 820);
			this.notListesiPanel1.TabIndex = 1;
			// 
			// Portal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1504, 835);
			this.Controls.Add(this.bilgilerimPanel1);
			this.Controls.Add(this.dersProgramıPanel1);
			this.Controls.Add(this.transkriptPanel1);
			this.Controls.Add(this.dersKayıtPanel1);
			this.Controls.Add(this.notListesiPanel1);
			this.Controls.Add(this.panel1);
			this.Name = "Portal";
			this.Text = "Portal";
			this.Load += new System.EventHandler(this.Portal_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Profil_Resmi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Ders_Kayıt;
		private System.Windows.Forms.Button Btn_Çıkış;
		private System.Windows.Forms.Button Btn_Bilgilerim;
		private System.Windows.Forms.Button btn_Ders_Programı;
		private System.Windows.Forms.Button btn_Transkript;
		private System.Windows.Forms.Button btn_Not_Listesi;
		private System.Windows.Forms.PictureBox Profil_Resmi;
		private System.Windows.Forms.Button btn_Fotoğraf_Değiş;
		private System.Windows.Forms.Panel panel6;
		private NotListesiPanel notListesiPanel1;
		private DersKayıtPanel dersKayıtPanel1;
		private System.Windows.Forms.Panel YanPanel;
		private TranskriptPanel transkriptPanel1;
		private DersProgramıPanel dersProgramıPanel1;
		private BilgilerimPanel bilgilerimPanel1;
		private System.Windows.Forms.Panel panel2;
	}
}