using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proje1
{
	public partial class Portal : Form
	{
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		string txbox_Öğrenci_No = "";
		public Portal()
		{
			InitializeComponent();
			dersKayıtPanel1.BringToFront();
			YanPanel.Location = new Point(0, btn_Ders_Kayıt.Location.Y);
			WindowState = FormWindowState.Maximized;

		}
		public void TxtAktar(string value)
		{
			txbox_Öğrenci_No = value;
		}
		private void Portal_Load(object sender, EventArgs e)
		{
			dersKayıtPanel1.TxtAktar(txbox_Öğrenci_No);
			//bilgilerimPanel1.TxtAktar(txbox_Öğrenci_No);
			notListesiPanel1.TxtAktar(txbox_Öğrenci_No);
			transkriptPanel1.TxtAktar(txbox_Öğrenci_No);

			try
			{
				int sayaç = 0;
				bağlantı.Open();
				using (MySqlCommand komut = new MySqlCommand("SELECT Ögrenci_Ad, Ögrenci_Soyad FROM Ogrenci WHERE ÖgrenciNo =@OgrenciNo AND Ögrenci_Ad IS NULL", bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{
						if (okuyucu.Read())
						{
							sayaç++;

						}
						if (sayaç != 0)//ad soyad dolu
						{
							bilgilerimPanel1.BringToFront();

						}
						
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex);
			}
		}//
		private void btn_Fotoğraf_Değiş_Click(object sender, EventArgs e)
		{
			OpenFileDialog ProfilResmi = new OpenFileDialog();
			ProfilResmi.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

			if (ProfilResmi.ShowDialog() == DialogResult.OK)
			{
				Profil_Resmi.BackgroundImage = Image.FromFile(ProfilResmi.FileName);
			}
		}
		private void Btn_Çıkış_Click(object sender, EventArgs e)
		{
			Öğrenci öğrenci = new Öğrenci();
			this.Hide();
			öğrenci.StartPosition = FormStartPosition.CenterScreen;
			öğrenci.ShowDialog();
		}
		private void DersKayıt_Click(object sender, EventArgs e)
		{
			dersKayıtPanel1.BringToFront();
			YanPanel.Location = new Point(0, btn_Ders_Kayıt.Location.Y);
			YanPanel.Size = new Size(29, 43);
		}
		private void btn_Not_Listesi_Click(object sender, EventArgs e)
		{
			//notListesiPanel1.TxtAktar(txbox_Öğrenci_No.ToString());

			notListesiPanel1.BringToFront();
			YanPanel.Location = new Point(0, btn_Not_Listesi.Location.Y);
			YanPanel.Size = new Size(29, 43);
		}
		private void btn_Transkript_Click(object sender, EventArgs e)
		{
			transkriptPanel1.BringToFront();
			YanPanel.Location = new Point(0, btn_Transkript.Location.Y);
			YanPanel.Size = new Size(29, 43);

		}
		private void btn_Ders_Programı_Click(object sender, EventArgs e)
		{
			dersProgramıPanel1.BringToFront();
			YanPanel.Location = new Point(0, btn_Ders_Programı.Location.Y);
			YanPanel.Size = new Size(29, 43);
		}
		private void Btn_Bilgilerim_Click(object sender, EventArgs e)
		{
			bilgilerimPanel1.BringToFront();

			//YanPanel.Location = new Point(0, Btn_Bilgilerim.Location.Y);
			//YanPanel.Size = new Size(50, 43);

		}
	}
}
