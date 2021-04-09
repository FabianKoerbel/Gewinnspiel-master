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
        string bildpfad;
        #endregion

        #region Methoden
        #endregion

        private void frmGewinnspiel_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Gewinnspiel hinzufügen"))
            {
                bildpfad = Application.StartupPath + "\\images\\default.jpg";
                pictureBox1.Image = Image.FromFile(bildpfad);
            }
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
                s.Ausgelost = cbAusglost.Checked;
                s.Bildpfad = txtBildpfad.Text;
                frmLogin.frmLog.gewinnspielListe.Add(s);
            }
            else // Gewinnspiel bearbeiten
            {
                foreach (Spiel s in frmLogin.frmLog.gewinnspielListe)
                {
                    if (s.SpielID == Convert.ToInt32(txtGewinnspielID.Text))
                    {
                        s.Bezeichnung = txtBezeichnung.Text;
                        s.Gewinn = txtGewinn.Text;
                        s.Wert = wert;
                        s.Ausgelost = cbAusglost.Checked;
                        s.Bildpfad = bildpfad;
                    }
                }
            }
            frmLogin.frmLog.serialisierenSpiel();
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.Filter = "Image FIles (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;|All Files (*.*)| *.*";
                ofd.InitialDirectory = "D://Fotos";
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    bildpfad = ofd.FileName;
                    txtBildpfad.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
