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
	public partial class NotListesiPanel : UserControl
	{
		string txbox_Öğrenci_No = "";
		string SınıfDönem = "";
		double ortalama = 0;
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		string dersAdi = "";
		double vizeNotu = 0;
		double finalNotu = 0;
		double butNotu = 0;
		string durum = "Sonuçlanmadı";
		string Notluk = "";
		string sonuç = "";
		string HarfNotu = "";



		public NotListesiPanel()
		{
			InitializeComponent();
		}

		private void NotListesiPanel_Load(object sender, EventArgs e)
		{
			//final notu 50 den az ise büt görünür olcak değilse visible
		}
		public void TxtAktar(string value)
		{
			txbox_Öğrenci_No = value;
		}
		private void SınıfDönemSeç_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			SınıfDönem = SınıfDönemSeç.Items[SınıfDönemSeç.SelectedIndex].ToString();

		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			// Satır yüksekliğini kontrol etmek için bu olayı kullanabilirsiniz.
			int istenenyükseklik = 54; // İstenen satır yüksekliği

			if (e.RowIndex >= 0 && e.RowIndex < VeriGösterici.Rows.Count)
			{
				// İstenen yükseklikten küçükse yüksekliği ayarla
				if (VeriGösterici.Rows[e.RowIndex].Height < istenenyükseklik)
				{
					VeriGösterici.Rows[e.RowIndex].Height = istenenyükseklik;
				}
			}
		}


		public static string HarfnotuHesap(double ortalama)
		{
			string harfNotu = "";
			if (ortalama >= 85 && ortalama <= 100) harfNotu = "AA";
			else if (ortalama >= 70 && ortalama < 85) harfNotu = "BA";
			else if (ortalama >= 60 && ortalama < 70) harfNotu = "BB";
			else if (ortalama >= 50 && ortalama < 63) harfNotu = "CC";
			else if (ortalama >= 50 && ortalama <= 62) harfNotu = "CB";
			else if (ortalama >= 0 && ortalama < 50) harfNotu = "FF";

			return harfNotu;
		}
		private void DönemGetir_Click_1(object sender, EventArgs e)
		{
			try
			{
				bağlantı.Open();//;

				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_adi, vize_notu, final_notu, but_notu  FROM Notlar  WHERE Ders_SınıfDönem = @DersSınıfdönem" +
															" AND Ögrenci_No = @OgrenciNo AND Ders_adi IS NOT NULL AND Ders_adi != ''", bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);
					komut.Parameters.AddWithValue("@DersSınıfdönem", SınıfDönem);


					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{

						DataTable dataTable = new DataTable();
						dataTable.Columns.Add("Ders Adı");
						dataTable.Columns.Add("Durum");
						dataTable.Columns.Add("Vize Notu");
						dataTable.Columns.Add("Final Notu");
						dataTable.Columns.Add("Büt Notu");
						dataTable.Columns.Add("Ortalama");
						dataTable.Columns.Add("Not");
						dataTable.Columns.Add("Sonuç");

						#region verigösterici gerekli kodlar
						VeriGösterici.DataSource = dataTable;
						VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme

						VeriGösterici.Columns[0].Width = 500;
						VeriGösterici.Columns[1].Width = 180;
						VeriGösterici.Columns[2].Width = 130;//sütun boyutları
						VeriGösterici.Columns[3].Width = 130;
						VeriGösterici.Columns[4].Width = 120;
						VeriGösterici.Columns[5].Width = 150;
						VeriGösterici.Columns[6].Width = 150;
						VeriGösterici.Columns[7].Width = 150;

						VeriGösterici.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
						VeriGösterici.AllowUserToResizeRows = false;
						//VeriGösterici.RowTemplate.Height = 424;
						VeriGösterici.RowPrePaint += dataGridView1_RowPrePaint;//satırların boyutları
						VeriGösterici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;//satır boyutları

						VeriGösterici.ScrollBars = ScrollBars.Horizontal;
						VeriGösterici.ScrollBars = ScrollBars.Vertical; // Yatay,dikey scrolları kaldırır


						VeriGösterici.RowHeadersVisible = false;
						VeriGösterici.ColumnHeadersVisible = false; //başlıklarını gizleme

						VeriGösterici.Font = new Font("Arial", 18);// font değiştirme
						VeriGösterici.BorderStyle = BorderStyle.None;//border kaldırdık
						VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme
						VeriGösterici.ReadOnly = true;//sadece okunur
						#endregion
						while (okuyucu.Read())
						{
							dersAdi = okuyucu.GetString("Ders_adi");
							vizeNotu = okuyucu.GetDouble("vize_notu");
							finalNotu = okuyucu.GetDouble("final_notu");
							butNotu = okuyucu.GetDouble("but_notu");


							if (butNotu == 0) { ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6); }
							else { ortalama = (vizeNotu * 0.4) + (butNotu * 0.6); }
							sonuç = (ortalama >= 50) ? "Geçti" : "Kaldı";
							if (vizeNotu != null&& vizeNotu != 0)
							{
								durum = "Sonuçlandı";
							}
							HarfNotu = HarfnotuHesap(ortalama);
							//dataTable.Load(okuyucu);


							dataTable.Rows.Add(dersAdi, durum, vizeNotu, finalNotu, butNotu, ortalama, HarfNotu, sonuç);

							//MessageBox.Show($"Ders: {dersAdi}\nVize: {vizeNotu}\nFinal: {finalNotu}\nBüt: {butNotu}\nOrtalama: {ortalama}\nDurum: {durum}");


							

						}


					}
				}
				bağlantı.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex);
			}
		}


	}
}
