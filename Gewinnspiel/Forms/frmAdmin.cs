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
        }

        #region Methoden

        private void einlesenGewinnspiele()
        {
            lvGewinnspiele.Items.Clear();
            for (int i =0; i<frmLogin.frmLog.gewinnspielListe.Count; i++)
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

        #endregion



 
    }
}
