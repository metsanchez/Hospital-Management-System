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
    public partial class GecmisMuayeneler : Form
    {
        public GecmisMuayeneler()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=HastaneSQL; user Id=postgres; Password=123");

        public void MuayeneleriListele(string txt)
        {
            conn.Open();
            NpgsqlCommand dbManage = new NpgsqlCommand(txt, conn);
            dbManage.Connection = conn;
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(dbManage);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            muayenelerDataGrid.DataSource = dataTable;

            dbManage.Dispose();

            conn.Close();
        }

        private void menuFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuFrm = new Form1();
            menuFrm.Show();
        }

        private void muayeneListeleBtn_Click(object sender, EventArgs e)
        {
            MuayeneleriListele("select * from \"Muayeneler\" order by \"tarih\"");


        }

        private void GecmisMuayeneler_Load(object sender, EventArgs e)
        {
            MuayeneleriListele("select * from \"Muayeneler\" order by \"tarih\"");
        }

        private void muayeneSilBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand muayeneSil = new NpgsqlCommand();
            muayeneSil.Connection = conn;
            muayeneSil.Parameters.AddWithValue("@hastatc", silTcTxt.Text);
            muayeneSil.Parameters.AddWithValue("@tarih", silTarihTxt.Text);
            muayeneSil.CommandType = CommandType.Text;
            muayeneSil.CommandText = "delete from \"Muayeneler\" where \"hastaTc\" = @hastatc AND \"tarih\" = @tarih";

            NpgsqlDataReader dr = muayeneSil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                muayenelerDataGrid.DataSource = dt;
            }
            muayeneSil.Dispose();
            conn.Close();
            MuayeneleriListele("select * from \"Muayeneler\" order by \"tarih\"");
        }
    }
}
