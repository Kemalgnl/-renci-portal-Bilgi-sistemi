namespace proje1
{
	partial class Öğrenci
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Öğrenci));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txbox_Öğrenci_No = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Öğrenci_Giriş = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txbox_Öğrenci_Şifre = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(333, -15);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(658, 380);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// txbox_Öğrenci_No
			// 
			this.txbox_Öğrenci_No.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txbox_Öğrenci_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.86486F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txbox_Öğrenci_No.Location = new System.Drawing.Point(638, 406);
			this.txbox_Öğrenci_No.Multiline = true;
			this.txbox_Öğrenci_No.Name = "txbox_Öğrenci_No";
			this.txbox_Öğrenci_No.Size = new System.Drawing.Size(257, 31);
			this.txbox_Öğrenci_No.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(356, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 42);
			this.label3.TabIndex = 2;
			this.label3.Text = "Öğrenci no";
			// 
			// btn_Öğrenci_Giriş
			// 
			this.btn_Öğrenci_Giriş.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Öğrenci_Giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Öğrenci_Giriş.Location = new System.Drawing.Point(877, 570);
			this.btn_Öğrenci_Giriş.Name = "btn_Öğrenci_Giriş";
			this.btn_Öğrenci_Giriş.Size = new System.Drawing.Size(114, 53);
			this.btn_Öğrenci_Giriş.TabIndex = 3;
			this.btn_Öğrenci_Giriş.Text = "Giriş";
			this.btn_Öğrenci_Giriş.UseVisualStyleBackColor = true;
			this.btn_Öğrenci_Giriş.Click += new System.EventHandler(this.Öğrenci_Giriş);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(356, 474);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 42);
			this.label4.TabIndex = 5;
			this.label4.Text = "Şifre";
			// 
			// txbox_Öğrenci_Şifre
			// 
			this.txbox_Öğrenci_Şifre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txbox_Öğrenci_Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.86486F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txbox_Öğrenci_Şifre.Location = new System.Drawing.Point(638, 495);
			this.txbox_Öğrenci_Şifre.Multiline = true;
			this.txbox_Öğrenci_Şifre.Name = "txbox_Öğrenci_Şifre";
			this.txbox_Öğrenci_Şifre.PasswordChar = '*';
			this.txbox_Öğrenci_Şifre.Size = new System.Drawing.Size(257, 31);
			this.txbox_Öğrenci_Şifre.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.21622F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(436, 682);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(459, 46);
			this.button3.TabIndex = 6;
			this.button3.Text = "Öğretmen giriş";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Öğretmenim);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txbox_Öğrenci_Şifre);
			this.groupBox1.Controls.Add(this.btn_Öğrenci_Giriş);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txbox_Öğrenci_No);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Location = new System.Drawing.Point(-3, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1333, 742);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// Öğrenci
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1330, 756);
			this.Controls.Add(this.groupBox1);
			this.Name = "Öğrenci";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Öğrenci_Giriş;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox txbox_Öğrenci_Şifre;
		public System.Windows.Forms.TextBox txbox_Öğrenci_No;
	}
}

