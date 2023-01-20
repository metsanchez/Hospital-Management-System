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
using static System.Net.Mime.MediaTypeNames;

namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    public partial class IlacEkrani : Form
    {
        public IlacEkrani()
        {
            InitializeComponent();
            IlaclariListele("select * from \"Ilaclar\" order by \"barkodNo\"");
        }

        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=HastaneSQL; user Id=postgres; Password=123");

        public void IlaclariListele(string txt)
        {
            conn.Open();
            NpgsqlCommand dbManage = new NpgsqlCommand(txt, conn);
            dbManage.Connection = conn;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(dbManage);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            ilaclarDataGrid.DataSource = dataTable;
            dbManage.Dispose();
            conn.Close();
        }

        private void IlacEkrani_Load(object sender, EventArgs e)
        {

        }

        private void ilacKaydetBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand ilacKyt = new NpgsqlCommand();
            ilacKyt.Connection = conn;

            ilacKyt.Parameters.AddWithValue("@IlacBarkod", Convert.ToInt32(ilacBarkodTxt.Text));
            ilacKyt.Parameters.AddWithValue("@IlacAdi", ilacAdTxt.Text);
            ilacKyt.Parameters.AddWithValue("@IlacTipi", ilacTipBox.Text);
           


            ilacKyt.CommandType = CommandType.Text;
            ilacKyt.CommandText = "insert into \"Ilaclar\" (\"barkodNo\", \"ilacAdi\", \"tipi\") values (@IlacBarkod, @IlacAdi, @IlacTipi)";
            
            ilacKyt.ExecuteNonQuery();
            conn.Close();

            IlaclariListele("select * from \"Ilaclar\" order by \"barkodNo\"");

        }

        private void ilacListeleBtn_Click(object sender, EventArgs e)
        {
            IlaclariListele("select * from \"Ilaclar\" order by \"barkodNo\"");
        }


        private void ilacSilBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand ilacSil = new NpgsqlCommand();
            ilacSil.Connection = conn;
            ilacSil.Parameters.AddWithValue("@IlacBarkod", Convert.ToInt32(silinecekIlacBarkodTxt.Text));
            ilacSil.CommandType = CommandType.Text;
            ilacSil.CommandText = "delete from \"Ilaclar\" where \"barkodNo\" = @IlacBarkod";
            ilacSil.ExecuteNonQuery();
            NpgsqlDataReader dr = ilacSil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                ilaclarDataGrid.DataSource = dt;
            }
            
            ilacSil.Dispose();
            
            conn.Close();

            IlaclariListele("select * from \"Ilaclar\" order by \"barkodNo\"");
        }

        private void menuFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuFrm = new Form1();
            menuFrm.Show();
        }

        private void ilacListeleBtn_Click_1(object sender, EventArgs e)
        {
            IlaclariListele("select * from \"Ilaclar\" order by \"barkodNo\"");
        }

        private void silinecekIlacBarkodTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ilacBarkodTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void barkodAratBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand hastaArat = new NpgsqlCommand("select \"hastaTc\", \"adi\", \"soyadi\", \"receteNo\" from \"Receteler\" where ilaclar LIKE '%" + hastaBulTxt.Text + "%'", conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(hastaArat);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            hastalarDataGrid.DataSource = dataTable;
            hastaArat.Dispose();
            conn.Close();
        }
    }
}
