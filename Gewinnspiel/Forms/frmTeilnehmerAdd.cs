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

namespace Gewinnspiel.Forms
{
    public partial class frmTeilnehmerAdd : Form
    {
        public frmTeilnehmerAdd()
        {
            InitializeComponent();
        }

        #region Variablen
        DateTime minus16;
        #endregion

        private void frmTeilnehmerAdd_Load(object sender, EventArgs e)
        {
            if (frmLogin.frmLog.activeUser==null)
            {
                cbAdmin.Visible = false;
                cbDeaktiviert.Visible = false;
                txtTID.Text = Teilnehmer.Autonum.ToString();
            }
            else
            {
                if (frmLogin.frmLog.activeUser.Admin)
                {
                    cbAdmin.Visible = true;
                    cbDeaktiviert.Visible = true;
                }
                else
                {
                    cbAdmin.Visible = false;
                    cbDeaktiviert.Visible = false;
                }
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtZuname.Text.Equals("") || txtVorname.Text.Equals("") || txtEmail2.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                return;
            }
            if (frmLogin.frmLog.activeUser==null && txtPasswort.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie ein Passwort ein!");
                return;
            }
            if (cbGeschlecht.SelectedIndex== -1) // kein Geschlecht ausgewählt
            {
                MessageBox.Show("Bitte wählen Sie das Geschlecht aus!");
                return;
            }

            minus16 = DateTime.Now.AddYears(-16);
            if (dtpGebDat.Value.Date > minus16)
            {
                MessageBox.Show("Bitte wählen Sie ihr Geburtsdatum aus, Sie müssen mindestens 16 Jahre alt sein!");
                return;
            }

            if (frmLogin.frmLog.activeUser==null) // Neuanlage
            {
                Teilnehmer t = new Teilnehmer();
                t.Nachname = txtZuname.Text;
                t.Vorname = txtVorname.Text;
                t.Passwort = frmLogin.frmLog.verschluesselnSHA512(txtPasswort.Text);
                t.Email = txtEmail2.Text;
                t.GetDate = dtpGebDat.Value.Date;
                t.Geschlecht = Convert.ToChar(cbGeschlecht.Text);
                t.Admin = false;
                t.Deaktiviert = false;
                frmLogin.frmLog.teilnehmerListe.Add(t);
                MessageBox.Show("Registrierung erfolgreich!");
            }
            else // Bearbeiten
            {

            }
            frmLogin.frmLog.serialisierenTeil();
            this.Close();
        }

        private void btnAuge_Click(object sender, EventArgs e)
        {
            if (txtPasswort.PasswordChar == '*')
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';
        }
    }
}
