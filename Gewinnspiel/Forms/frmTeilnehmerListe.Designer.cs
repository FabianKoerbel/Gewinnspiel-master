namespace Gewinnspiel.Forms
{
    partial class frmTeilnehmerListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teilnehmerHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 359);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerHinzufügenToolStripMenuItem,
            this.teilnehmerBearbeitenToolStripMenuItem,
            this.teilnehmerDeaktivierenToolStripMenuItem,
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // teilnehmerHinzufügenToolStripMenuItem
            // 
            this.teilnehmerHinzufügenToolStripMenuItem.Name = "teilnehmerHinzufügenToolStripMenuItem";
            this.teilnehmerHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.teilnehmerHinzufügenToolStripMenuItem.Text = "Teilnehmer hinzufügen";
            // 
            // teilnehmerBearbeitenToolStripMenuItem
            // 
            this.teilnehmerBearbeitenToolStripMenuItem.Name = "teilnehmerBearbeitenToolStripMenuItem";
            this.teilnehmerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.teilnehmerBearbeitenToolStripMenuItem.Text = "Teilnehmer bearbeiten";
            // 
            // teilnehmerDeaktivierenToolStripMenuItem
            // 
            this.teilnehmerDeaktivierenToolStripMenuItem.Name = "teilnehmerDeaktivierenToolStripMenuItem";
            this.teilnehmerDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.teilnehmerDeaktivierenToolStripMenuItem.Text = "Teilnehmer de/aktivieren";
            // 
            // teilnehmerZumGewinnspielHinzufügenToolStripMenuItem
            // 
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Name = "teilnehmerZumGewinnspielHinzufügenToolStripMenuItem";
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Text = "Teilnehmer zum Gewinnspiel hinzufügen";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zuname";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vorname";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-Mail";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Geburtsdatum";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Geschlecht";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Admin";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Deaktiviert";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Spiele";
            // 
            // frmTeilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.listView1);
            this.Name = "frmTeilnehmer";
            this.Text = "frmTeilnehmer";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerZumGewinnspielHinzufügenToolStripMenuItem;
    }
}