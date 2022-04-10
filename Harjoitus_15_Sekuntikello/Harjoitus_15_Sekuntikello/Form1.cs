using System.Diagnostics;

namespace Harjoitus_15_Sekuntikello
{
    public partial class SekkariForm : Form
    {
        private Stopwatch sekkari;
        public SekkariForm()
        {
            InitializeComponent();
        }


        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }
        private void PysaytaLB(object sender, EventArgs e)
        {
            sekkari.Stop();
        }
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void SekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }

        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
     }
}