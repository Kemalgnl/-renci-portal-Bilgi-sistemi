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
	public partial class BilgilerimPanel : UserControl
	{
		string isim = "";
		string Soyisim = "";
		string TelNo = "";
		string Eposta = "";
		MySqlConnection bağlantı = new MySqlConnection("server=localhost;port=3306;database=proje1_2;uid=root;password=root;");

		public BilgilerimPanel()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			isim = lbl_İsimKayıt.Text;
			Soyisim = lbl_SoyİsimKayıt.Text;
			TelNo = lbl_TelNoKayıt.Text;
			Eposta = lbl_EPostaKayıt.Text;
			try
			{
				bağlantı.Open();

				using (MySqlCommand komut = new MySqlCommand("INSERT INTO ogrenci ( Ögrenci_Ad, Ögrenci_Soyad, TelNo, Eposta) VALUES (@Isim, @Soyisim, @TelNo, @Eposta)", bağlantı))
				{
					komut.Parameters.AddWithValue("@Isim", isim);
					komut.Parameters.AddWithValue("@Soyisim", Soyisim);
					komut.Parameters.AddWithValue("@TelNo", TelNo);
					komut.Parameters.AddWithValue("@Eposta", Eposta);

					MessageBox.Show("kayıt başarıyla eklendi");

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("bir hata oluştu" + ex.Message);

			}
			bağlantı.Close();



		}
	}
}
