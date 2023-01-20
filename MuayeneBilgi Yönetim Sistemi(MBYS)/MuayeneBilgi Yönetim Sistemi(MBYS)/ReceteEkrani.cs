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
    public partial class ReceteEkrani : Form
    {
        public ReceteEkrani()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=HastaneSQL; user Id=postgres; Password=123");

        public void ReceteListele(string txt)
        {
            conn.Open();
            NpgsqlCommand dbManage = new NpgsqlCommand(txt, conn);
            dbManage.Connection = conn;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(dbManage);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            receteDataGrid.DataSource = dataTable;

            dbManage.Dispose();

            conn.Close();
        }
        private void ReceteEkrani_Load(object sender, EventArgs e)
        {
            ReceteListele("select * from \"Receteler\" order by \"receteNo\"");
        }

        private void menuFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuFrm = new Form1();
            menuFrm.Show();
        }

        private void receteListeleBtn_Click(object sender, EventArgs e)
        {
            ReceteListele("select * from \"Receteler\" order by \"receteTarihi\"");
        }

        private void receteBulBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand receteBul = new NpgsqlCommand("select \"receteNo\" , \"adi\" , \"soyadi\" , \"receteTarihi\" , \"ilaclar\"  from \"Receteler\" where \"hastaTc\" ='" + hastaTcTxt.Text + "' order by \"receteTarihi\"", conn);
            receteBul.Connection = conn;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(receteBul);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            receteDataGrid.DataSource = dataTable;

            receteBul.Dispose();

            conn.Close();
        }

        private void receteSilBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand receteSil = new NpgsqlCommand();
            receteSil.Connection = conn;
            receteSil.Parameters.AddWithValue("@receteno", receteSilTxt.Text);
            receteSil.CommandType = CommandType.Text;
            receteSil.CommandText = "delete from \"Receteler\" where \"receteNo\" = @receteno";

            NpgsqlDataReader dr = receteSil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                receteDataGrid.DataSource = dt;
            }
            receteSil.Dispose();
            conn.Close();
            ReceteListele("select * from \"Receteler\" order by \"receteNo\"");
        }

        private void receteNoListBtn_Click(object sender, EventArgs e)
        {
            ReceteListele("select * from \"Receteler\" order by \"receteNo\"");
        }
    }
}
