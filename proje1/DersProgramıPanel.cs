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
	public partial class DersProgramıPanel : UserControl
	{
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");
		string txbox_Öğrenci_No = "";
		string SınıfDönem = "";
		string dersAdi = "";
		string dersSınıf = "";
		string dersSaat = "";
		string[] dersAdıDizisi = new string[8];
		string[] dersSınıfDizisi = new string[8];
		int sayaç = 0, sayaç2 = 0, sayaç3 = 0,sayaç4=0,sayaç5=0;
		DataTable dataTable = new DataTable();
		string[] haftaDizisi = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
		string[] DersSaatiDizisi = { "9.00-9.45", "10.00-10.45", "11.00-11.45", "13.00-13.45", "14.00-14.45", "16.00-16.45" };
		Random rastgele = new Random();
		DataRow rowToDelete = null;
		int rasgeleSayi = 0;


		public DersProgramıPanel()
		{
			InitializeComponent();
		}

		private void DersProgramıPanel_Load(object sender, EventArgs e)
		{
			#region verigösterici gerekli kodlar
			VeriGösterici4.DataSource = dataTable;
			VeriGösterici4.AllowUserToAddRows = false;//en atl boş satır silme

			dataTable.Columns.Add("Ders Adı");
			dataTable.Columns.Add("DersSaat");
			dataTable.Columns.Add("DersSınıf");

			VeriGösterici4.Columns[0].Width = 750;
			VeriGösterici4.Columns[1].Width = 350;
			VeriGösterici4.Columns[2].Width = 350;//sütun boyutları


			VeriGösterici4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			VeriGösterici4.AllowUserToResizeRows = false;
			//VeriGösterici.RowTemplate.Height = 424;
			VeriGösterici4.RowPrePaint += dataGridView1_RowPrePaint;//satırların boyutları
			VeriGösterici4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;//satır boyutları

			VeriGösterici4.RowHeadersVisible = false;
			VeriGösterici4.ColumnHeadersVisible = false; //başlıklarını gizleme

			VeriGösterici4.Font = new Font("Arial", 15);// font değiştirme
			VeriGösterici4.BorderStyle = BorderStyle.None;//border kaldırdık
			VeriGösterici4.AllowUserToAddRows = false;//en atl boş satır silme
			VeriGösterici4.ReadOnly = true;//sadece okunur
			#endregion

		}
		public void TxtAktar(string value)//*****************************************
		{
			txbox_Öğrenci_No = value;
		}
		private void SınıfDönemSeç_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			SınıfDönem = SınıfDönemSeç.Items[SınıfDönemSeç.SelectedIndex].ToString();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			VeriGösterici4.Rows.Clear();
		}

		private void DönemGetir_Click(object sender, EventArgs e)
		{
			
			sayaç2 = 0;
			sayaç3 = 0;
			
			sayaç = 0;
			sayaç4 = sayaç5;
			sayaç5 = 0;
			for (int i = 0; i < sayaç4; i++)
			{
				rowToDelete = dataTable.Rows[0];
				rowToDelete.Delete();

			}
			
			try
			{
				bağlantı.Open();//;SELECT DersAdi, DersSaat FROM DersProgram WHERE OgrenciNo = @OgrenciNo AND DersSinifDonem = @DersSinifDonem;

				using (MySqlCommand komut = new MySqlCommand("SELECT Ders_Adı,Ders_Saati,Ders_Sınıfı FROM DersProgram WHERE Ders_SınıfDönem = @DersSınıfdönem ", bağlantı))
				{
					//komut.Parameters.AddWithValue("@OgrenciNo", txbox_Öğrenci_No);//AND Ögrenci_No = @OgrenciNo
					komut.Parameters.AddWithValue("@DersSınıfdönem", SınıfDönem);

					using (MySqlDataReader okuyucu = komut.ExecuteReader())
					{

						while (okuyucu.Read())
						{
							
							dersAdi = okuyucu.GetString("Ders_Adı");
							dersSınıf = okuyucu.GetString("Ders_Sınıfı");
							dersSaat = okuyucu.GetString("Ders_Saati");//şimdilik kullanmayacağız

							dersAdıDizisi[sayaç] = dersAdi;
							dersSınıfDizisi[sayaç] = dersSınıf;

							sayaç++;
							if (sayaç == 8)
								break;

						}
					}
				}
			}
			catch (Exception ex) { MessageBox.Show("Hata oluştu: " + ex.Message); }

			sayaç = 0;
			sayaç2 = 0;
			sayaç3 = 0;
			for (int i = 0; i < haftaDizisi.Length; i++)
			{
				dataTable.Rows.Add(haftaDizisi[i], "Ders Sınıfı", "Ders Saati");//pazartesi salı
				VeriGösterici4.Rows[i + sayaç3].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
				sayaç5++;
				for (int j = 0; j < 2; j++)//max 2 ders olur günde
				{
					dersAdi = dersAdıDizisi[j + sayaç];
					dersSınıf = dersSınıfDizisi[j + sayaç];
					sayaç5+=3;
					dataTable.Rows.Add(dersAdi, dersSınıf, DersSaatiDizisi[j + sayaç2]);
					dataTable.Rows.Add(dersAdi, dersSınıf, DersSaatiDizisi[j + 1 + sayaç2]);
					dataTable.Rows.Add(dersAdi, dersSınıf, DersSaatiDizisi[j + 2 + sayaç2]);
					sayaç2 += 2;
				}
				sayaç3 += 6;
				sayaç2 = 0;
				sayaç += 2;
				if (sayaç == 8)
				{
					bağlantı.Close();
					break;
				}
			}
			sayaç= 0;
			sayaç ++;

		}
		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			// Satır yüksekliğini kontrol etmek için bu olayı kullanabilirsiniz.
			int desiredHeight = 32; // İstenen satır yüksekliği

			if (e.RowIndex >= 0 && e.RowIndex < VeriGösterici4.Rows.Count)
			{
				// İstenen yükseklikten küçükse yüksekliği ayarla
				if (VeriGösterici4.Rows[e.RowIndex].Height < desiredHeight)
				{
					VeriGösterici4.Rows[e.RowIndex].Height = desiredHeight;
				}
			}
		}
	}
}
