namespace Harjoitus_13_Suosikkinimet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
			VastausLB.Text = "";
			VastausLB.Visible = false;
			string[] pojat = File.ReadAllLines("C:/Users/jyrit/source/Ohjelmistokehittaja/Harjoitus_13_Suosikkinimet/Pojat.txt");
			string[] tytot = File.ReadAllLines("C:/Users/jyrit/source/Ohjelmistokehittaja/Harjoitus_13_Suosikkinimet/Tytot.txt");
			string nimi = NimiTB.Text;

			int laskurip = 1;
			int laskurit = 1;

			foreach (string poika in pojat)
			{
				if (nimi == poika)
				{
				VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
				VastausLB.Visible = true;
				}
				laskurip++;
			}

			foreach (string tytto in tytot)
			{
				if (nimi == tytto)
				{
				VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttojen nimi vuonna 2020";
				VastausLB.Visible = true;
				}
				laskurit++;
			}

			if (VastausLB.Visible == false)
			{
				VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
				VastausLB.Visible = true;
			}
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}