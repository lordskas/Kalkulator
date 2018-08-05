using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {

            try
            {

                double wzrost = Convert.ToDouble(txtWzrost.Text);
                double waga = Convert.ToDouble(txtWaga.Text);
                int wiek = Convert.ToInt32(txtWiek.Text);

                if (radioK.Checked)
                {
                    double obliczenia = 665.09 + (9.56 * waga) + (1.85 * wzrost) - (4.67 * wiek);
                    string wynik = obliczenia.ToString();

                    txtPPM.Text = wynik;
                }

                if (radioM.Checked)
                {
                    double obliczenia = 66.47 + (13.7 * waga) + (5.0 * wzrost) - (6.76 * wiek);
                    string wynik = obliczenia.ToString();

                    txtPPM.Text = wynik;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Błąd");
            }

            if (checkBox1.Checked)
            {
                double x = Convert.ToDouble(txtPPM.Text);
                txtCPM.Text = (x * 1).ToString();
            }
            else if (checkBox2.Checked)
            {
                double x = Convert.ToDouble(txtPPM.Text);
                txtCPM.Text = (x * 1.4).ToString();
            }
            else if (checkBox3.Checked)
            {
                double x = Convert.ToDouble(txtPPM.Text);
                txtCPM.Text = (x * 1.8).ToString();
            }
            else if (checkBox4.Checked)
            {
                double x = Convert.ToDouble(txtPPM.Text);
                txtCPM.Text = (x * 2).ToString();
            }
            else if (checkBox5.Checked)
            {
                double x = Convert.ToDouble(txtPPM.Text);
                txtCPM.Text = (x * 2.3).ToString();
            }
            else
            {
                txtCPM.Text = "Wybierz akrywność fizyczną";
            }

        }
    }
}
