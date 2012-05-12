using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20120509_Konto_mit_GUI
{
    class Konto
    {
        private int kontoNummer;
        private string inhaber;
        private double kontoStand;

        public Konto(string inhaber, int kontoNummer, double kontoStand)
        {
            this.inhaber = inhaber;
            this.kontoNummer = kontoNummer;
            this.kontoStand = kontoStand;
        }

        public Konto()
        {
        }

        public void einzahlen(double betrag)
        {
            kontoStand = kontoStand + betrag;
        }

        public void abheben(double betrag)
        {
            kontoStand = kontoStand - betrag;
        }

        public double kontoStandAnzeigen()
        {
            return kontoStand;
        }

        public void setKontoNummer(int zahl)
        {
            kontoNummer = zahl;
        }

        public int getKontoNummer()
        {
            return kontoNummer;
        }

        public void setInhaber(string inhaber)
        {
            this.inhaber = inhaber;
        }

        public string getInhaber()
        {
            return inhaber;
        }

        public void setKontoStand(double betrag)
        {
            kontoStand = betrag;
        } 
    }
}
