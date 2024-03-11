namespace proje1
{
	partial class Öğretmen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Öğretmen));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtÖğretmen_Şifre = new System.Windows.Forms.TextBox();
			this.Btn_Öğretmen_Giriş = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtÖğretmen_No = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtÖğretmen_Şifre);
			this.groupBox1.Controls.Add(this.Btn_Öğretmen_Giriş);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtÖğretmen_No);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Location = new System.Drawing.Point(0, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1333, 742);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.21622F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(436, 682);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(459, 46);
			this.button3.TabIndex = 6;
			this.button3.Text = "Öğrenci giriş";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Öğrenciyim);
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
			// txtÖğretmen_Şifre
			// 
			this.txtÖğretmen_Şifre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtÖğretmen_Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.86486F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtÖğretmen_Şifre.Location = new System.Drawing.Point(638, 495);
			this.txtÖğretmen_Şifre.Multiline = true;
			this.txtÖğretmen_Şifre.Name = "txtÖğretmen_Şifre";
			this.txtÖğretmen_Şifre.PasswordChar = '*';
			this.txtÖğretmen_Şifre.Size = new System.Drawing.Size(257, 31);
			this.txtÖğretmen_Şifre.TabIndex = 4;
			// 
			// Btn_Öğretmen_Giriş
			// 
			this.Btn_Öğretmen_Giriş.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Btn_Öğretmen_Giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_Öğretmen_Giriş.Location = new System.Drawing.Point(877, 570);
			this.Btn_Öğretmen_Giriş.Name = "Btn_Öğretmen_Giriş";
			this.Btn_Öğretmen_Giriş.Size = new System.Drawing.Size(114, 53);
			this.Btn_Öğretmen_Giriş.TabIndex = 3;
			this.Btn_Öğretmen_Giriş.Text = "Giriş";
			this.Btn_Öğretmen_Giriş.UseVisualStyleBackColor = true;
			this.Btn_Öğretmen_Giriş.Click += new System.EventHandler(this.Öğretmen_Giriş);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(356, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 42);
			this.label3.TabIndex = 2;
			this.label3.Text = "Personel No";
			// 
			// txtÖğretmen_No
			// 
			this.txtÖğretmen_No.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtÖğretmen_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.86486F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtÖğretmen_No.Location = new System.Drawing.Point(638, 406);
			this.txtÖğretmen_No.Multiline = true;
			this.txtÖğretmen_No.Name = "txtÖğretmen_No";
			this.txtÖğretmen_No.Size = new System.Drawing.Size(257, 31);
			this.txtÖğretmen_No.TabIndex = 1;
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
			// Öğretmen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1330, 756);
			this.Controls.Add(this.groupBox1);
			this.Name = "Öğretmen";
			this.Text = "Öğretmen";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Btn_Öğretmen_Giriş;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtÖğretmen_No;
		private System.Windows.Forms.PictureBox pictureBox2;
		protected System.Windows.Forms.TextBox txtÖğretmen_Şifre;
	}
}