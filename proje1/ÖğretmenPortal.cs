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
	public partial class ÖğretmenPortal : Form
	{
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		string dersAdi = "";
		double vizeNotu = 0;
		double finalNotu = 0;
		double butNotu = 0;
		int sayaç = 0;
		int sayaç2 = 0;
		DataTable dataTable = new DataTable();
		DataRow rowToDelete = null;

		public ÖğretmenPortal()
		{
			InitializeComponent();
		}
		

		private void Btn_Öğretmen_Getir_Click(object sender, EventArgs e)
		{
			sayaç2 = sayaç;
			sayaç = 0;
			for (int i = 0; i < sayaç2; i++)
			{
				rowToDelete = dataTable.Rows[0];
				rowToDelete.Delete();

			}

			try
			{
				bağlantı.Open();

				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_adi, vize_notu, final_notu, but_notu FROM Notlar WHERE Ögrenci_No = @OgrenciNo " +
															"AND Ders_adi='Algoritmalar' OR Ders_adi='Veri Yapıları'AND Ögrenci_No = @OgrenciNo ", bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No.Text);
					//komut.Parameters.AddWithValue("@DersSınıfdönem", SınıfDönem);


					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{

						while (okuyucu.Read())
						{
							sayaç++;
							dersAdi = okuyucu.GetString("Ders_adi");
							vizeNotu = okuyucu.GetDouble("vize_notu");
							finalNotu = okuyucu.GetDouble("final_notu");
							butNotu = okuyucu.GetDouble("but_notu");
							//MessageBox.Show($"Ders: {dersAdi}\nVize: {vizeNotu}\nFinal: {finalNotu}\nBüt: {butNotu}\nOrtalama: {ortalama}\nDurum: {kredi}\nkredi: {akts}\nakts: ");

							panel3.Location = new System.Drawing.Point(1269, 281);

							//dataTable.Load(okuyucu);
							dataTable.Rows.Add(dersAdi, vizeNotu, finalNotu, butNotu);

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

		private void ÖğretmenPortal_Load(object sender, EventArgs e)
		{
			panel3.Location = new System.Drawing.Point(-100, -100);
			dataTable.Columns.Add("Ders Adı");
			dataTable.Columns.Add("Durum");
			dataTable.Columns.Add("Kredi");
			dataTable.Columns.Add("AKTS");
			dataTable.Columns.Add("Ortalama");


			VeriGösterici.DataSource = dataTable;
			VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme

			VeriGösterici.Columns[0].Width = 420;
			VeriGösterici.Columns[1].Width = 130;
			VeriGösterici.Columns[2].Width = 130;//sütun boyutları
			VeriGösterici.Columns[3].Width = 130;
			VeriGösterici.Columns[4].Width = 130;



			VeriGösterici.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			VeriGösterici.AllowUserToResizeRows = false;
			//VeriGösterici.RowTemplate.Height = 424;
			VeriGösterici.RowPrePaint += dataGridView1_RowPrePaint;//satırların boyutları
			VeriGösterici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;//satır boyutları

			VeriGösterici.RowHeadersVisible = false;
			VeriGösterici.ColumnHeadersVisible = false; //başlıklarını gizleme

			VeriGösterici.Font = new Font("Arial", 18);// font değiştirme
			VeriGösterici.BorderStyle = BorderStyle.None;//border kaldırdık
			VeriGösterici.AllowUserToAddRows = false;//en atl boş satır silme
													 //VeriGösterici.ReadOnly = true;//sadece okunur
													 // DataGridView'deki belirli hücreleri ortalama
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
		public static void VeriDeğiştir(MySqlConnection bağlantı, double vizeNotu, double finalNotu, double butNotu, string txbox_Öğrenci_No,string dersAdi)
		{
			try
			{
				bağlantı.Open();

				string sorgu = "UPDATE Notlar SET  vize_notu = @VizeNotu, final_notu = @FinalNotu,but_notu = @ButNotu WHERE Ögrenci_No = @OgrenciNo AND Ders_adi=@DersAdı";
				using (MySqlCommand komut = new MySqlCommand(sorgu, bağlantı))
				{
					komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);
					komut.Parameters.AddWithValue("@VizeNotu", vizeNotu);
					komut.Parameters.AddWithValue("@FinalNotu", finalNotu);
					komut.Parameters.AddWithValue("@ButNotu", butNotu);
					komut.Parameters.AddWithValue("@DersAdı", dersAdi);

					int etkilenenSatir = komut.ExecuteNonQuery();

					if (etkilenenSatir > 0)
					{

						bağlantı.Close();
					}
					else
					{
						MessageBox.Show("hata.");
						bağlantı.Close();

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
		private void btn_Ders1_ort_Düzenle_Click(object sender, EventArgs e)
		{

			vizeNotu = Convert.ToDouble(VeriGösterici.Rows[0].Cells[1].Value);
			finalNotu = Convert.ToDouble(VeriGösterici.Rows[0].Cells[2].Value);
			butNotu = Convert.ToDouble(VeriGösterici.Rows[0].Cells[3].Value);

			if (sayaç==1)
			{
				 dersAdi = "Veri Yapıları";
			}
			VeriDeğiştir(bağlantı, vizeNotu, finalNotu, butNotu, txbox_Öğrenci_No.Text, dersAdi);
		}

		private void btn_Ders2_ort_Düzenle_Click(object sender, EventArgs e)
		{
			vizeNotu = Convert.ToDouble(VeriGösterici.Rows[1].Cells[1].Value);
			finalNotu = Convert.ToDouble(VeriGösterici.Rows[1].Cells[2].Value);
			butNotu = Convert.ToDouble(VeriGösterici.Rows[1].Cells[3].Value);
			if (sayaç==2)
			{
				dersAdi = "Algoritma";
			}

			VeriDeğiştir(bağlantı, vizeNotu, finalNotu, butNotu, txbox_Öğrenci_No.Text,dersAdi);
		}

		private void Btn_Çıkış_Click(object sender, EventArgs e)
		{
			Öğretmen öğretmen= new Öğretmen();
			this.Hide();
			öğretmen.StartPosition = FormStartPosition.CenterScreen;
			öğretmen.ShowDialog();
		}
	}
}
