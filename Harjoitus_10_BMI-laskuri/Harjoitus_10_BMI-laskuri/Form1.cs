namespace Harjoitus_10_BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void BMIBT_Click(object sender, EventArgs e)
            {
                double paino = 0, pituus = 0;
                paino = Convert.ToDouble(PainoTB.Text);
                pituus = Convert.ToDouble(PituusTB.Text);

                double bmi = Math.Round(paino / (pituus * pituus), 2);

                if (bmi < 18.5)
                {
                    BmiLB.Text = "Painoindeksisi on: " + bmi;
                    BmiLB.ForeColor = Color.Aqua;
                    kuvausLB.Text = "Alipaino";
                    kuvausLB.ForeColor = Color.Aqua;
                    kuvausLB.Visible = true;
                    BmiLB.Visible = true;
                }

                else if (bmi < 25)
                {
                    BmiLB.Text = "Painoindeksisi on: " + bmi;
                    BmiLB.ForeColor = Color.Green;
                    kuvausLB.Text = "Normaalipaino";
                    kuvausLB.ForeColor = Color.Green;
                    kuvausLB.Visible = true;
                    BmiLB.Visible = true;
                }

                else if (bmi < 40)
                {
                    BmiLB.Text = "Painoindeksisi on: " + bmi;
                    BmiLB.ForeColor = Color.Gold;
                    kuvausLB.Text = "Ylipaino";
                    kuvausLB.ForeColor = Color.Gold;
                    kuvausLB.Visible = true;
                    BmiLB.Visible = true;
                }

                else
                {
                    BmiLB.Text = "Painoindeksisi on: " + bmi;
                    BmiLB.ForeColor = Color.Red;
                    kuvausLB.Text = "Huomattava ylipaino";
                    kuvausLB.ForeColor = Color.Red;
                    kuvausLB.Visible = true;
                    BmiLB.Visible = true;
            }
            }






        }
    }
