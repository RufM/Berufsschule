using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20120509_Konto_mit_GUI
{
    public partial class Form1 : Form
    {
        private List<Konto> kontenListe = new List<Konto>();
        private List<Konto> result = new List<Konto>();
        Konto actual;


        public Form1()
        {
            InitializeComponent();
        }

        private void btngetInhaber_Click(object sender, EventArgs e)
        {
            result.Clear();

            kontenListe.ForEach(delegate(Konto i)
            {
                if (i.getInhaber() == tbxinhaber.ToString())
                {
                    tbxkontoNummer.Text = i.getKontoNummer().ToString();
                    tbxkontoStand.Text = i.kontoStandAnzeigen().ToString();
                    result.Add(i);
                }
            });

            if (result.Count > 1)
            {
                MessageBox.Show("Menge an Resultaten > 1", "Mehrere Konten vorhanden!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
            actual = result.First();
        }

        private void btncreateInhaber_Click(object sender, EventArgs e)
        {
            Konto addthis = new Konto(tbxinhaber.ToString(), Convert.ToInt32(tbxkontoNummer.Text), Convert.ToDouble(tbxkontoStand.Text));
            kontenListe.Add(addthis);
            actual = addthis;
        }

        private void btneinzahlen_Click(object sender, EventArgs e)
        {
            try
            {
                actual.einzahlen(Convert.ToDouble(tbxbetrag.Text));
                tbxkontoStand.Text = actual.kontoStandAnzeigen().ToString(); ;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Der Input ist wahrscheinlich keine gültige Nummer", "Umwandlungsfehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnauszahlen_Click(object sender, EventArgs e)
        {
            try
            {
                actual.abheben(Convert.ToDouble(tbxbetrag.Text));
                tbxkontoStand.Text = actual.kontoStandAnzeigen().ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Der Input ist wahrscheinlich keine gültige Nummer", "Umwandlungsfehler",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}