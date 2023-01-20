using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    public partial class HastaIslemleri : Form
    {
        public HastaIslemleri()
        {
            InitializeComponent();
            HastaListele("select * from \"Hastalar\"");
            
        }

        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=HastaneSQL; user Id=postgres; Password=123");

        public void HastaListele(string txt)
        {
            conn.Open();
            NpgsqlCommand dbManage = new NpgsqlCommand(txt, conn);
            dbManage.Connection = conn;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(dbManage);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            hastalarDataGrid.DataSource = dataTable;

            dbManage.Dispose();
            
            conn.Close();
        }

        private void menuFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuFrm = new Form1();
            menuFrm.Show();
        }

        private void hastalariListeleBtn_Click(object sender, EventArgs e)
        {
            HastaListele("select * from \"Hastalar\"");
        }

        private void hastaKaydetBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand hastaKyt = new NpgsqlCommand();
            hastaKyt.Connection = conn;

            hastaKyt.Parameters.AddWithValue("@HastaTC", hastaTcTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaAdi", hastaAdTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaSoyadi", hastaSoyadTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaDogumYeri", hastaDogumYeriTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaDogumTarihi", hastaDogumTarihiTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaMedeniDrm", medeniDrmBox.Text);
            hastaKyt.Parameters.AddWithValue("@HastaAdres", adresTxt.Text);
            hastaKyt.Parameters.AddWithValue("@HastaTelNo", telefonNoTxt.Text);
            
            
            
            hastaKyt.CommandType = CommandType.Text;
            hastaKyt.CommandText = "insert into \"Hastalar\" (\"hastaTc\", \"ad\", \"soyad\", \"dogumYeri\", \"dogumTarihi\", \"medeniDurum\", \"adres\", \"telefon\") values (@HastaTC, @HastaAdi, @HastaSoyadi, @HastaDogumYeri, @HastaDogumTarihi, @HastaMedeniDrm, @HastaAdres, @HastaTelNo)";
            hastaKyt.ExecuteNonQuery();
            conn.Close();

            HastaListele("select * from \"Hastalar\"");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void hastaSilBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand hastaSil = new NpgsqlCommand();
            hastaSil.Connection = conn;
            hastaSil.Parameters.AddWithValue("@HastaTC", silinecekHastaTxt.Text);
            hastaSil.CommandType = CommandType.Text;
            hastaSil.CommandText = "delete from \"Hastalar\" where \"hastaTc\" = @HastaTC";
            
            NpgsqlDataReader dr = hastaSil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                hastalarDataGrid.DataSource = dt;
            }
            hastaSil.Dispose();
            
            conn.Close();

            HastaListele("select * from \"Hastalar\"");
        }

        private void hastaTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefonNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void silinecekHastaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
