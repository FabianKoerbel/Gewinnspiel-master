using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gewinnspiel.Classes;
using Gewinnspiel.Forms;

namespace Gewinnspiel
{
    public partial class frmGewinnspiel : Form
    {
        public frmGewinnspiel()
        {
            InitializeComponent();
        }


        #region Variablen
        #endregion

        #region Methoden
        #endregion

        private void frmGewinnspiel_Load(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            double wert;
            if (txtBezeichnung.Text.Equals("") || txtGewinn.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Bezeichnung als auch Gewinn aus!");
                return;
            }
            try
            {
                wert = Double.Parse(txtWert.Text, System.Globalization.NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!");
                return;
            }

            if (this.Text.Equals("Gewinnspiel hinzufügen"))
            {
                Spiel s = new Spiel();
                s.Bezeichnung = txtBezeichnung.Text;
                s.Gewinn = txtGewinn.Text;
                s.Wert = wert;
                s.Ausgelost = false;
                s.Bildpfad = txtBildpfad.Text;
                frmLogin.frmLog.gewinnspielListe.Add(s);
            }
            else // Gewinnspiel bearbeiten
            {

            }
            frmLogin.frmLog.serialisierenSpiel();
        }
    }
}
