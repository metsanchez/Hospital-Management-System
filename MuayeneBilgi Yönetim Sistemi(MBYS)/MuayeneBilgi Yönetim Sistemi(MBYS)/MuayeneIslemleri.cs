using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    public partial class MuayeneIslemleri : Form
    {
        public MuayeneIslemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=HastaneSQL; user Id=postgres; Password=123");

        private void menuFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuFrm = new Form1();
            menuFrm.Show();
        }
       
        private void MuayeneIslemleri_Load(object sender, EventArgs e)
        {
            conn.Open();
            List<string> ilaclar1 = new List<string>();
            List<string> ilaclar2 = new List<string>();
            List<string> ilaclar3 = new List<string>();
            List<string> ilaclar4 = new List<string>();
            List<string> ilaclar5 = new List<string>();
            
            NpgsqlCommand ilacOku = new NpgsqlCommand("select \"ilacAdi\" from \"Ilaclar\" order by \"barkodNo\"", conn);
            
            
            NpgsqlDataReader reader = ilacOku.ExecuteReader();
            while (reader.Read())
            {
                ilaclar1.Add(reader.GetString(0));
                ilaclar2.Add(reader.GetString(0));
                ilaclar3.Add(reader.GetString(0));
                ilaclar4.Add(reader.GetString(0));
                ilaclar5.Add(reader.GetString(0));
            }
            ilacCombo1.DataSource = ilaclar1;
            ilacCombo2.DataSource = ilaclar2;
            ilacCombo3.DataSource = ilaclar3;
            ilacCombo4.DataSource = ilaclar4;
            ilacCombo5.DataSource = ilaclar5;
            ilacCombo1.ResetText();
            ilacCombo2.ResetText();
            ilacCombo3.ResetText();
            ilacCombo4.ResetText();
            ilacCombo5.ResetText();
            
            conn.Close();

            ReceteNoGuncelle();
           
        }

        public void ReceteNoGuncelle()
        {
            conn.Open();
            NpgsqlCommand receteNo = new NpgsqlCommand("SELECT MAX(\"receteNo\") from \"Receteler\" ", conn);
            string maxReceteNo = receteNo.ExecuteScalar().ToString();
            receteNoLbl.Text += " " + maxReceteNo;
            conn.Close();
        }

        private void muayeneKaydetBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand hastaKontrol = new NpgsqlCommand("SELECT \"hastaTc\" FROM \"Hastalar\" WHERE \"hastaTc\" = '" + hastaTcTxt.Text + "'", conn);
            NpgsqlDataReader hastaRead = hastaKontrol.ExecuteReader();
            if (hastaRead.HasRows)
            {
                conn.Close();
                bool eslesmeVar = false;
                conn.Open();
                NpgsqlCommand muayeneKyt = new NpgsqlCommand();
                NpgsqlCommand muayeneDoldur = new NpgsqlCommand();
                NpgsqlCommand receteKyt = new NpgsqlCommand();
                NpgsqlCommand randevuKontrol = new NpgsqlCommand("SELECT \"tarih\" FROM \"Muayeneler\" WHERE \"hastaTc\" = '" + hastaTcTxt.Text + "'", conn);
                randevuKontrol.Connection = conn;
                muayeneKyt.Connection = conn;
                muayeneDoldur.Connection = conn;
                NpgsqlDataReader reader = randevuKontrol.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["tarih"].ToString() == muayeneTarihTxt.Text)
                        {
                            // randevu tarihi alınan randevu ile aynı ise
                            MessageBox.Show("Bu TC kimlik numarası ile daha önce randevu alınmış, lütfen başka bir tarih seçiniz.");
                            conn.Close();
                            eslesmeVar = true;
                            return;
                        }
                    }
                    reader.Close();
                    if (eslesmeVar == false)
                    {
                        muayeneKyt.Parameters.AddWithValue("@hastatc", hastaTcTxt.Text);
                        muayeneKyt.Parameters.AddWithValue("@tarih", muayeneTarihTxt.Text);
                        muayeneKyt.Parameters.AddWithValue("@sikayet", hastaSikayetTxt.Text);
                        muayeneKyt.Parameters.AddWithValue("@tani", taniTxt.Text);
                        muayeneKyt.Parameters.AddWithValue("@tedavi", tedaviTxt.Text);
                        muayeneKyt.Parameters.AddWithValue("@receteno", receteNoTxt.Text);

                        muayeneKyt.CommandText = "insert into \"Muayeneler\" (\"tarih\", \"hastaTc\", \"sikayet\", \"tani\", \"tedavi\", \"receteno\" ) values (@tarih, @hastatc, @sikayet, @tani, @tedavi, @receteno)";
                        muayeneDoldur.CommandText = "update \"Muayeneler\" set \"ad\" = \"Hastalar\".\"ad\" , \"soyad\" = \"Hastalar\".\"soyad\", \"dogumYeri\" = \"Hastalar\".\"dogumYeri\" , \"dogumTarihi\" = \"Hastalar\".\"dogumTarihi\" from \"Hastalar\" where \"Hastalar\".\"hastaTc\" = '" + hastaTcTxt.Text + "' AND \"Muayeneler\".\"hastaTc\" = '" + hastaTcTxt.Text + "'";
                        MessageBox.Show("Randevu Başarıyla Oluşturuldu !");

                        if (receteNoTxt.Text == "" || receteNoTxt.Text == " " || receteNoTxt.Text == null)
                        {
                            
                        }
                        else
                        {

                            receteKyt.Connection = conn;
                            receteKyt.Parameters.AddWithValue("@hastatc", hastaTcTxt.Text);
                            receteKyt.Parameters.AddWithValue("@ad", hastaAdTxt.Text);
                            receteKyt.Parameters.AddWithValue("@soyad", hastaSoyadTxt.Text);
                            receteKyt.Parameters.AddWithValue("@receteTarih", receteTarihTxt.Text);
                            receteKyt.Parameters.AddWithValue("@receteno", receteNoTxt.Text);
                            receteKyt.Parameters.AddWithValue("@ilaclar", (ilacCombo1.Text.ToString() + " " + ilacAdetCombo1.Text.ToString() + "  " + ilacCombo2.Text.ToString() + " " + ilacAdetCombo2.Text.ToString() + "  " + ilacCombo3.Text.ToString() + " " + ilacAdetCombo3.Text.ToString() + "  " + ilacCombo4.Text.ToString() + " " + ilacAdetCombo4.Text.ToString()));
                            receteKyt.CommandType = CommandType.Text;
                            receteKyt.CommandText = "insert into \"Receteler\" (\"receteNo\", \"hastaTc\", \"adi\", \"soyadi\", \"receteTarihi\", \"ilaclar\" ) values (@receteno, @hastatc, @ad, @soyad, @receteTarih, @ilaclar)";
                            MessageBox.Show("Reçete Oluşturuldu");
                            conn.Close();
                            ReceteNoGuncelle();
                            conn.Open();
                            receteKyt.ExecuteNonQuery();
                        }
                    }
                    
                    
                    randevuKontrol.ExecuteNonQuery();
                    muayeneKyt.ExecuteNonQuery();
                    muayeneDoldur.ExecuteNonQuery();
                    
                    conn.Close();
                }
                else if (!reader.HasRows)
                {
                    reader.Close();
                    muayeneKyt.Parameters.AddWithValue("@hastatc", hastaTcTxt.Text);
                    muayeneKyt.Parameters.AddWithValue("@tarih", muayeneTarihTxt.Text);
                    muayeneKyt.Parameters.AddWithValue("@sikayet", hastaSikayetTxt.Text);
                    muayeneKyt.Parameters.AddWithValue("@tani", taniTxt.Text);
                    muayeneKyt.Parameters.AddWithValue("@tedavi", tedaviTxt.Text);
                    muayeneKyt.Parameters.AddWithValue("@receteno", receteNoTxt.Text);

                    muayeneKyt.CommandText = "insert into \"Muayeneler\" (\"tarih\", \"hastaTc\", \"sikayet\", \"tani\", \"tedavi\", \"receteno\" ) values (@tarih, @hastatc, @sikayet, @tani, @tedavi, @receteno)";
                    muayeneDoldur.CommandText = "update \"Muayeneler\" set \"ad\" = \"Hastalar\".\"ad\" , \"soyad\" = \"Hastalar\".\"soyad\", \"dogumYeri\" = \"Hastalar\".\"dogumYeri\" , \"dogumTarihi\" = \"Hastalar\".\"dogumTarihi\" from \"Hastalar\" where \"Hastalar\".\"hastaTc\" = '" + hastaTcTxt.Text+ "' AND \"Muayeneler\".\"hastaTc\" = '" + hastaTcTxt.Text + "'";
                    MessageBox.Show("Randevu Başarıyla Oluşturuldu !");

                    if (receteNoTxt.Text == "" || receteNoTxt.Text == " " || receteNoTxt.Text == null)
                    {
                        return;
                    }
                    else
                    {

                        receteKyt.Connection = conn;
                        receteKyt.Parameters.AddWithValue("@hastatc", hastaTcTxt.Text);
                        receteKyt.Parameters.AddWithValue("@ad", hastaAdTxt.Text);
                        receteKyt.Parameters.AddWithValue("@soyad", hastaSoyadTxt.Text);
                        receteKyt.Parameters.AddWithValue("@receteTarih", receteTarihTxt.Text);
                        receteKyt.Parameters.AddWithValue("@receteno", receteNoTxt.Text);
                        receteKyt.Parameters.AddWithValue("@ilaclar", (ilacCombo1.Text.ToString() + " " + ilacAdetCombo1.Text.ToString() + "  " + ilacCombo2.Text.ToString() + " " + ilacAdetCombo2.Text.ToString() + "  " + ilacCombo3.Text.ToString() + " " + ilacAdetCombo3.Text.ToString() + "  " + ilacCombo4.Text.ToString() + " " + ilacAdetCombo4.Text.ToString()));
                        receteKyt.CommandType = CommandType.Text;
                        receteKyt.CommandText = "insert into \"Receteler\" (\"receteNo\", \"hastaTc\", \"adi\", \"soyadi\", \"receteTarihi\", \"ilaclar\" ) values (@receteno, @hastatc, @ad, @soyad, @receteTarih, @ilaclar)";
                        MessageBox.Show("Reçete Oluşturuldu");
                        conn.Close();
                        ReceteNoGuncelle();
                        conn.Open();
                        receteKyt.ExecuteNonQuery();

                    }
                    
                    randevuKontrol.ExecuteNonQuery();
                    muayeneKyt.ExecuteNonQuery();
                    muayeneDoldur.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Bu TC kimlik numarasına sahip hasta bulunmamaktadır. Lütfen başka bir TC giriniz veya hastayı kaydediniz!");
                    conn.Close();
                }

            }
        }

        private void ilacResBtn_Click(object sender, EventArgs e)
        {
            ilacCombo1.ResetText();
            ilacCombo2.ResetText();
            ilacCombo3.ResetText();
            ilacCombo4.ResetText();
            ilacCombo5.ResetText();
            ilacAdetCombo1.ResetText();
            ilacAdetCombo2.ResetText();
            ilacAdetCombo3.ResetText();
            ilacAdetCombo4.ResetText();
            ilacAdetCombo5.ResetText();
        }

        private void hastaTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void muayeneTarihTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void receteNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void receteTarihTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
    }


