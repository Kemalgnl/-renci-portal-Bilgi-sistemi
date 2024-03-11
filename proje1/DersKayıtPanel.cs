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
	public partial class DersKayıtPanel : UserControl
	{
		string txbox_Öğrenci_No = "";
		string SınıfDönem = "";
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		int sayaç = 0, sayaç2 = 0;
		string Ders_id = "";
		string Ders_Adi = "";
		double Ders_kredi = 0;
		double Ders_akts = 0;
		DataRow rowToDelete = null;
		DataTable dataTable = new DataTable();
		public DersKayıtPanel()
		{
			InitializeComponent();

		}
		public void TxtAktar(string value)
		{
			txbox_Öğrenci_No = value;
		}

		private void DersKayıtPanel_Load(object sender, EventArgs e)
		{
			
			panel1.Location = new Point(-300, -300);

			dataGridView1.DataSource = dataTable;
			dataGridView1.AllowUserToAddRows = false;//en atl boş satır silme
			dataTable.Columns.Add("Ders Adı");
			dataTable.Columns.Add("Durum");
			dataTable.Columns.Add("Kredi");
			dataTable.Columns.Add("AKTS");

			dataGridView1.Columns[0].Width = 600;
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[2].Width = 200;//sütun boyutları
			dataGridView1.Columns[3].Width = 150;

			dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;//satırların boyutları
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;//satır boyutları

			dataGridView1.RowHeadersVisible = false;
			dataGridView1.ColumnHeadersVisible = false; //başlıklarını gizleme

			dataGridView1.Font = new Font("Arial", 18);// font değiştirme
			dataGridView1.BorderStyle = BorderStyle.None;//border kaldırdık
			dataGridView1.AllowUserToAddRows = false;//en atl boş satır silme
			dataGridView1.ReadOnly = true;//sadece okunur
		}
		//ortalama durumuna göre geçip kalması 
		private void SınıfDönemSeç_SelectedIndexChanged(object sender, EventArgs e)
		{
			SınıfDönem = SınıfDönemSeç.Items[SınıfDönemSeç.SelectedIndex].ToString();
			//MessageBox.Show("seçilen sınıf dönem " + SınıfDönem);
		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			// Satır yüksekliğini kontrol etmek için bu olayı kullanabilirsiniz.
			int istenenyükseklik = 54; // İstenen satır yüksekliği

			if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
			{
				// İstenen yükseklikten küçükse yüksekliği ayarla
				if (dataGridView1.Rows[e.RowIndex].Height < istenenyükseklik)
				{
					dataGridView1.Rows[e.RowIndex].Height = istenenyükseklik;
				}
			}
		}

		private void DönemGetir_Click(object sender, EventArgs e)
		{
			panel1.Location = new Point(1041, 154);

			sayaç2 = sayaç;
			sayaç = 0;
			for (int i = 0; i < sayaç2; i++)
			{
				if (dataTable != null)
				{
					rowToDelete = dataTable.Rows[0];
					rowToDelete.Delete();
				}
			}

			try
			{
				bağlantı.Open();
				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_adi,Ders_kredi,Ders_akts FROM dersler WHERE Ders_SınıfDönem=@DersSınıfdönem", bağlantı))
				{
					//komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);
					komut.Parameters.AddWithValue("@DersSınıfdönem", SınıfDönem);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{

						while (okuyucu.Read())
						{
							Ders_Adi = okuyucu.GetString("Ders_adi");
							Ders_kredi = okuyucu.GetDouble("Ders_kredi");
							Ders_akts= okuyucu.GetDouble("Ders_akts");

							sayaç++;

							dataTable.Rows.Add(Ders_Adi, Ders_kredi, Ders_akts);
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
		public static void SqlVeriSorgulaEkle(int dersSıra, MySqlConnection bağlantı, string SınıfDönem, string txbox_Öğrenci_No)
		{
			string Ders_id = "";
			string Ders_adi = "";
			int Ders_kredi = 0;
			int Ders_akts = 0;

			try//(Ders_id, Ders_adi, Ders_kredi, Ders_akts, Ders_SınıfDönem,ÖgrenciNo,Ders_Sıra)
			{
				bağlantı.Open();
				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_id, Ders_adi,Ders_kredi,Ders_akts FROM Dersler WHERE Ders_SınıfDönem = @SınıfDönem AND Ders_Sıra=@DersSıra ", bağlantı))
				{
					komut.Parameters.AddWithValue("@SınıfDönem", SınıfDönem);//ilgili sınıfDönemin verilerini istediğk
					komut.Parameters.AddWithValue("@DersSıra", dersSıra);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{
						if (okuyucu.Read())
						{
							Ders_id = okuyucu.GetString("Ders_ID");
							Ders_adi = okuyucu.GetString("Ders_adi");
							Ders_kredi = okuyucu.GetInt32("Ders_kredi");
							Ders_akts = okuyucu.GetInt32("Ders_akts");//bu 4 satırda ilgili dönemin ilk dersini okuduk ders1 ekle olduğundan
							okuyucu.Close();
							using (MySqlCommand Ekle = new MySqlCommand("INSERT INTO Notlar (Not_id, vize_notu,final_notu,but_notu,Ders_SınıfDönem,Ders_Adi,Ögrenci_No, Ders_kredi,Ders_akts)" +
																		" VALUES (@NotId,@vizeNotu,@finalNotu,@but_notu,@DersSınıfDönem,@DersAdı, @OgrenciNo,@DersKredi, @DersAKTS)", bağlantı))
							{
								Ekle.Parameters.AddWithValue("@NotId", 1);
								Ekle.Parameters.AddWithValue("@vizeNotu", 0);
								Ekle.Parameters.AddWithValue("@finalNotu", 0);
								Ekle.Parameters.AddWithValue("@but_notu", 0);
								Ekle.Parameters.AddWithValue("@DersSınıfDönem", SınıfDönem);
								Ekle.Parameters.AddWithValue("@DersAdı", Ders_adi);
								Ekle.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);
								Ekle.Parameters.AddWithValue("@DersKredi", Ders_kredi);
								Ekle.Parameters.AddWithValue("@DersAKTS", Ders_akts);
								
						

								int ilgiliSatır = Ekle.ExecuteNonQuery();

								if (ilgiliSatır > 0)
								{
									MessageBox.Show("Kayıt başarıyla eklendi.");
								}
								else
								{
									MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
								}
							}
						}
						else
						{
							MessageBox.Show("bir hata oldu");
						}

					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}

		}
		//derslerin sıralarını güncelle******************************************************************************************************************
		private void btn_Ders1_Ekle_Click(object sender, EventArgs e)//ders1'i mysql eekler
		{
			int dersSıra = 1;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);//6*2,5-3,4-1,
			btn_Ders1_Ekle.Enabled = false;

		}

		private void btn_Ders2_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 2;//1
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders2_Ekle.Enabled = false;

		}

		private void btn_Ders3_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 3;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders3_Ekle.Enabled = false;

		}

		private void btn_Ders4_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 4;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders4_Ekle.Enabled = false;
		}

		private void btn_Ders5_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 5;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders5_Ekle.Enabled = false;
		}

		private void btn_Ders6_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 6;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders6_Ekle.Enabled = false;
		}

		private void btn_Ders7_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 8;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders7_Ekle.Enabled = false;
		}

		private void btn_Ders8_Ekle_Click(object sender, EventArgs e)
		{
			int dersSıra = 7;
			bağlantı.Close();
			SqlVeriSorgulaEkle(dersSıra, bağlantı, SınıfDönem, txbox_Öğrenci_No);
			btn_Ders8_Ekle.Enabled = false;
		}



	}
}


