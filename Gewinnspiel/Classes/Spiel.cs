using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnspiel.Classes
{
    public class Spiel
    {
        //Objektvariablen
        private int spielID;
        private string bezeichnung;
        private string gewinn;
        private string preis;
        private double wert;
        private List<Teilnehmer> listeTeilnehmer;
        private bool ausgelost;
        private string bildpfad;

        //Klassenvariablen
        public static int anzahl;
        public static int autonum = 1001;

        //Konstruktor
        public Spiel()
        {
            SpielID = autonum;
            autonum++;
        }

        public Spiel(string bezeichnung, string preis, string gewinn, double wert, List<Teilnehmer> listeTeilnehmer, bool ausgelost, string bildpfad)
        {
            spielID = autonum;
            autonum++;
            this.bezeichnung = bezeichnung;
            this.gewinn = gewinn;
            this.preis = preis;
            this.wert = wert;
            this.listeTeilnehmer = listeTeilnehmer;
            this.ausgelost = ausgelost;
            this.bildpfad = bildpfad;
        }

        public int SpielID { get; set; }

        public string Bezeichnung { get; set; }

        public string Preis { get; set; }

        public string Gewinn { get; set; }

        public double Wert { get; set; }

        public List<Teilnehmer> listeTeilnerhmer { get; set; }

        public bool Ausgelost { get; set; }

        public string Bildpfad { get; set; }

        public static int Autonum { get; set; }

        public static int Anzahl { get; set; }

        public override string ToString()
        {
            return spielID + ";" + bezeichnung + ";" + gewinn + ";" + wert + ";" + ausgelost;
        }
    }
}
