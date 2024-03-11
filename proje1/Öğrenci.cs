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

	public partial class Öğrenci : Form
	{
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		public Öğrenci()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}
		//asdasdasdasdasdasd
		private void Öğrenci_Giriş(object sender, EventArgs e)
		{
			
			try
			{
				bağlantı.Open();
				using (MySqlCommand komut = new MySqlCommand("SELECT * FROM Ogrenci WHERE ÖgrenciNo= @OgrenciNo AND ÖgrenciŞifre= @OgrenciSifre", bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No.Text);
					komut.Parameters.AddWithValue("@OgrenciSifre", txbox_Öğrenci_Şifre.Text);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{
						int count = 0;

						while (okuyucu.Read())
						{
							count++;
						}

						if (count >= 1)
						{
							bağlantı.Close();
							Portal portal = new Portal();
							portal.TxtAktar(txbox_Öğrenci_No.Text);

							portal.StartPosition = FormStartPosition.CenterScreen;
							this.Hide();
							portal.ShowDialog();
						}

						else
						{
							bağlantı.Close();
							MessageBox.Show("Kullanıcı adı ve şifre yanlış.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex);
			}
			bağlantı.Close();
		}

		private void Öğretmenim(object sender, EventArgs e)
		{
			Öğretmen Öğretmen = new Öğretmen();
			this.Hide();

			Öğretmen.ShowDialog();
		}
	}
}
