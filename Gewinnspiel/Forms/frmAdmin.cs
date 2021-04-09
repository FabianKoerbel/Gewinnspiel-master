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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        #region Variablen
        ListViewItem lvItem;
        #endregion

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lvGewinnspiele.FullRowSelect = true;
            lvTeilnehmer.FullRowSelect = true;
            rbAktiv.Checked = true;
            einlesenGewinnspiele();
        }

        #region Methoden       

        private void einlesenGewinnspiele()
        {
            lvGewinnspiele.Items.Clear();
            for (int i = 0; i < frmLogin.frmLog.gewinnspielListe.Count; i++)
            {
                if (rbAktiv.Checked)
                {
                    if (!frmLogin.frmLog.gewinnspielListe[i].Ausgelost)
                    {
                        lvItem = new ListViewItem();
                        lvItem.ImageIndex = i;
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].SpielID.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Bezeichnung);
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Gewinn);
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Wert.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Ausgelost.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Bildpfad);
                        lvGewinnspiele.Items.Add(lvItem);
                    }
                }
                if (rbAbgeschlossen.Checked)
                {
                    if (!frmLogin.frmLog.gewinnspielListe[i].Ausgelost)
                    {
                        lvItem = new ListViewItem();
                        lvItem.ImageIndex = i;
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].SpielID.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Bezeichnung);
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Gewinn);
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Wert.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Ausgelost.ToString());
                        lvItem.SubItems.Add(frmLogin.frmLog.gewinnspielListe[i].Bildpfad);
                        lvGewinnspiele.Items.Add(lvItem);
                    }
                }
            }
            lvGewinnspiele.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvGewinnspiele.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void hinzufuegenGewinnspiel()
        {
            frmGewinnspiel frmGew = new frmGewinnspiel();
            frmGew.Text = "Gewinnspiel hinzufügen";
            frmGew.txtGewinnspielID.Text = Spiel.autonum.ToString();
            frmGew.ShowDialog();
        }
        private void bearbeitenGewinnspiel()
        {
            if (lvGewinnspiele.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie ein Gewinnspiel aus!");
                return;
            }
            frmGewinnspiel frmGew = new frmGewinnspiel();
            frmGew.Text = "Gewinnspiel hinzufügen";
            lvItem = lvGewinnspiele.SelectedItems[0];
            frmGew.txtGewinnspielID.Text = lvItem.SubItems[1].Text;
            frmGew.txtBezeichnung.Text = lvItem.SubItems[2].Text;
            frmGew.txtGewinn.Text = lvItem.SubItems[3].Text;
            frmGew.txtWert.Text = lvItem.SubItems[4].Text;
            frmGew.cbAusglost.Checked = Convert.ToBoolean(lvItem.SubItems[5].Text);
            //frmGew.pictureBox1.Image = Image.FromFile(lvItem.SubItems[6].Text);
            frmGew.ShowDialog();
            einlesenGewinnspiele();
        }


        #endregion

        private void gewinnspielHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinzufuegenGewinnspiel();
        }

        private void gewinnspielBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bearbeitenGewinnspiel();
        }
    }
    } 