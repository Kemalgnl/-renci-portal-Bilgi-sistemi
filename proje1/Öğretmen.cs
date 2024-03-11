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
	public partial class Öğretmen : Form
	{
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");

		public Öğretmen()
		{

			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}


		private void Öğrenciyim(object sender, EventArgs e)
		{
			Öğrenci Öğrenci = new Öğrenci();
			this.Hide();
			Öğrenci.StartPosition = FormStartPosition.CenterScreen;
			Öğrenci.ShowDialog();

		}

		private void Öğretmen_Giriş(object sender, EventArgs e)
		{
			//Portal portal = new Portal();
			//this.Hide();
			//portal.StartPosition = FormStartPosition.CenterScreen;
			//portal.ShowDialog();

			try
			{
				bağlantı.Open();
				using (MySqlCommand komut = new MySqlCommand("SELECT * FROM Personel WHERE Personel_No= @PersonelNo AND Personel_Şifre= @PersonelSifre", bağlantı))
				{
					komut.Parameters.AddWithValue("@PersonelNo", txtÖğretmen_No.Text);
					komut.Parameters.AddWithValue("@PersonelSifre", txtÖğretmen_Şifre.Text);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{
						int count = 0;

						while (okuyucu.Read())
						{
							count++;
						}

						if (count >= 1)
						{
							ÖğretmenPortal öğretmenportal = new ÖğretmenPortal();
							bağlantı.Close();
							this.Hide();
							öğretmenportal.StartPosition = FormStartPosition.CenterScreen;
							öğretmenportal.ShowDialog();
						}

						else
						{
							MessageBox.Show("Kullanıcı adı veya şifre yanlış");
						}
					}
				}
			}
			catch (Exception ex)
			{
				bağlantı.Close();
				MessageBox.Show("Hata: " + ex);
			}
			bağlantı.Close();
		}
	}
}
