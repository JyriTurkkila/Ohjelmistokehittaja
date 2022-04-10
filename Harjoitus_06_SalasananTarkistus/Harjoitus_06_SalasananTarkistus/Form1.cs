namespace Harjoitus_06_SalasananTarkistus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kkOKulta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttajatunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}