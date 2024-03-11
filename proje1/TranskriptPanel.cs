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
	public partial class TranskriptPanel : UserControl
	{
		string txbox_Öğrenci_No = "",SınıfDönem = "", dersAdi = "", durum = "Sonuçlanmadı",
			Notluk = "",sonuç = "",HarfNotu = "",HarfPuan = "";

		double ortalama = 0, vizeNotu = 0, finalNotu = 0, akts = 0, kredi = 0, butNotu = 0,KrediNotToplam = 0, dönemOrtalama = 0;

		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		 
		int KrediToplam = 0,sayaç = 0, sayaç2 = 0,dersKodu = 0;

		public double[] OrtalamaDizisi = new double[8], KrediDizisi = new double[8];

		DataTable dataTable = new DataTable();
		object deger = null;
		DataRow rowToDelete = null;

		public TranskriptPanel()
		{
			InitializeComponent();
		}

		private void TranskriptPanel_Load(object sender, EventArgs e)
		{
			panel3.Location = new System.Drawing.Point(-500, -500);

			dataTable.Columns.Add("Ders Adı");
			dataTable.Columns.Add("Durum");
			dataTable.Columns.Add("Kredi");
			dataTable.Columns.Add("AKTS");
			dataTable.Columns.Add("Ortalama");
			dataTable.Columns.Add("Not");
			dataTable.Columns.Add("Sonuç");

			VeriGösterici.DataSource = dataTable;
			VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme

			VeriGösterici.Columns[0].Width = 450;
			VeriGösterici.Columns[1].Width = 170;
			VeriGösterici.Columns[2].Width = 150;//sütun boyutları
			VeriGösterici.Columns[3].Width = 150;
			VeriGösterici.Columns[4].Width = 200;
			VeriGösterici.Columns[5].Width = 220;
			VeriGösterici.Columns[6].Width = 170;


			VeriGösterici.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			VeriGösterici.AllowUserToResizeRows = false;

			VeriGösterici.RowPrePaint += dataGridView1_RowPrePaint;//satırların boyutları
			VeriGösterici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;//satır boyutları
			VeriGösterici.ScrollBars = ScrollBars.Horizontal;
			VeriGösterici.ScrollBars = ScrollBars.Vertical; // Yatay,dikey scrolları kaldırır

			VeriGösterici.RowHeadersVisible = false;
			VeriGösterici.ColumnHeadersVisible = false; //başlıklarını gizleme

			VeriGösterici.Font = new Font("Arial", 18);// font değiştirme
			VeriGösterici.BorderStyle = BorderStyle.None;//border kaldırdık
			VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme
													

		}
		public void TxtAktar(string value)
		{
			txbox_Öğrenci_No = value;//ilk panelden öğrenci numarasını aldığımız kod
		}

		private void SınıfDönemSeç_SelectedIndexChanged(object sender, EventArgs e)
		{
			SınıfDönem = SınıfDönemSeç.Items[SınıfDönemSeç.SelectedIndex].ToString();//hangi sınıf dönemi seçtik
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
			//ortalama olarak verilen notu AA lık sisteme çevirdiğimiz kod
			string harfNotu = "";
			if (ortalama >= 85 && ortalama <= 100) harfNotu = "AA";
			else if (ortalama >= 70 && ortalama < 85) harfNotu = "BA";
			else if (ortalama >= 60 && ortalama < 70) harfNotu = "BB";
			else if (ortalama >= 50 && ortalama < 63) harfNotu = "CC";
			else if (ortalama >= 50 && ortalama < 62) harfNotu = "CB";
			else if (ortalama >= 0 && ortalama < 50) harfNotu = "FF";

			return harfNotu;
		}
		public static string HarfPuanHesap(string harfNotu)
		{
			//AA lık sistemden 4lük sisteme çevirdiğimiz kod
			string HarfPuan = "";
			if (harfNotu == "AA") HarfPuan = "4";
			else if (harfNotu == "BA") HarfPuan = "3,5";
			else if (harfNotu == "BB") HarfPuan = "3";
			else if (harfNotu == "CC") HarfPuan = "2,5";
			else if (harfNotu == "CB") HarfPuan = "2";
			else if (harfNotu == "FF") HarfPuan = "0";

			return HarfPuan;
		}
		private void DönemGetir_Click(object sender, EventArgs e)
		{
			panel3.Location = new System.Drawing.Point(1287, 162);

			KrediNotToplam = 0;
			KrediToplam = 0;
			sayaç2 = sayaç;
			sayaç = 0;
			for (int i = 0; i < sayaç2; i++)
			{
				rowToDelete = dataTable.Rows[0];//sınıfDönem verisini değiştirdikten sonra yeni tablo için 
				rowToDelete.Delete();			//tabloyu temizledik

			}
			try
			{
				bağlantı.Open();//bağlantımızı açtık

				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_adi, vize_notu, final_notu, but_notu,Ders_akts,Ders_kredi FROM Notlar  WHERE" +
															" Ders_SınıfDönem = @DersSınıfdönem AND Ögrenci_No = @OgrenciNo AND Ders_adi IS NOT NULL AND Ders_adi != ''", bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);//öğrenci no ve DersSınıf döneme göre
					komut.Parameters.AddWithValue("@DersSınıfdönem", SınıfDönem);//öğrencinin notlarını getiren sorgu


					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{

						while (okuyucu.Read())
						{
							dersAdi = okuyucu.GetString("Ders_adi");
							vizeNotu = okuyucu.GetDouble("vize_notu");
							finalNotu = okuyucu.GetDouble("final_notu");
							kredi = okuyucu.GetDouble("Ders_kredi");
							akts = okuyucu.GetDouble("Ders_akts");
							butNotu = okuyucu.GetDouble("but_notu");

							if (butNotu == 0) { ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6); }
							else { ortalama = (vizeNotu * 0.4) + (butNotu * 0.6); }

							if (sayaç == 8) { break; }

							OrtalamaDizisi[sayaç] = ortalama;//
							KrediDizisi[sayaç] = kredi;

							if (ortalama >= 50)
								sonuç = "Geçti";
							else
								sonuç = "Kaldı";

							if (vizeNotu != null && finalNotu != null) { durum = "Sonuçlandı"; }

							HarfNotu = HarfnotuHesap(ortalama);//aa bb veriis geliyor
							HarfPuan = HarfPuanHesap(HarfNotu);//aa bb yi 2,5 3 e dönüştürdük

							KrediNotToplam += +kredi * Convert.ToDouble(HarfPuan);//***********************************

							KrediToplam += Convert.ToInt32(kredi);

							dataTable.Rows.Add(dersAdi, durum, kredi, akts, ortalama, HarfNotu, sonuç);
							sayaç++;
						}
					}
				}
				bağlantı.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex);
			}

			dönemOrtalama = KrediNotToplam / KrediToplam;
			lbl_dönem_Ort.Text = dönemOrtalama.ToString("N2");
		}
		public void DersOrtalamaDüzenle(int dersKodu)
		{
			deger = VeriGösterici.Rows[dersKodu].Cells[5].Value.ToString().ToUpper();//değişen veri aa bb olarak geldi
			HarfNotu = HarfnotuHesap(OrtalamaDizisi[dersKodu]);//aa bb verisi geldi

			KrediNotToplam -= Convert.ToDouble(HarfPuanHesap(HarfNotu)) + KrediDizisi[dersKodu];//3,5*kredi

			KrediNotToplam += Convert.ToDouble(HarfPuanHesap(HarfNotu)) * KrediDizisi[dersKodu];

			dönemOrtalama = KrediNotToplam / KrediToplam;
			if (dönemOrtalama > 4.0)
			{
				lbl_dönem_Ort.Text = 4.0.ToString("N2");
			}
			else
			{
				lbl_dönem_Ort.Text = dönemOrtalama.ToString("N2");
			}
		}


		private void btn_Ders1_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 0;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders2_ort_Düzenle_Click(object sender, EventArgs e)
		{
			
			dersKodu = 1;
			DersOrtalamaDüzenle(dersKodu);
			
		}

		private void btn_Ders3_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 2;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders4_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 3;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders5_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 4;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders6_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 5;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders7_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 6;
			DersOrtalamaDüzenle(dersKodu);
		}

		private void btn_Ders8_ort_Düzenle_Click(object sender, EventArgs e)
		{
			dersKodu = 7;
			DersOrtalamaDüzenle(dersKodu);
		}
		
	}

}

