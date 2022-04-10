using System.IO;

namespace Harjoitus_14_Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\jyrit\\source\\Ohjelmistokehittaja\\Harjoitus_14_Paivakirja\\demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Users/jyrit/source/Ohjelmistokehittaja/Harjoitus_14_Paivakirja/demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}