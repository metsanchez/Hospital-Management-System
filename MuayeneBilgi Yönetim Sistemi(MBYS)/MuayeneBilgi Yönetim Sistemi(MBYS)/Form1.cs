namespace MuayeneBilgi_Yönetim_Sistemi_MBYS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaFrmBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaIslemleri hastaEkrani = new HastaIslemleri();
            hastaEkrani.Show();
        }

        private void muayeneFrmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuayeneIslemleri muayeneEkrani = new MuayeneIslemleri();
            muayeneEkrani.Show();
        }

        private void gecmisMuayeneFrmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GecmisMuayeneler gecmisMuayeneler = new GecmisMuayeneler();
            gecmisMuayeneler.Show();
        }

        private void ilacFrmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            IlacEkrani ilacFrm = new IlacEkrani();
            ilacFrm.Show();
        }

        private void receteFrmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceteEkrani receteEkrani = new ReceteEkrani();
            receteEkrani.Show();
        }
    }
}