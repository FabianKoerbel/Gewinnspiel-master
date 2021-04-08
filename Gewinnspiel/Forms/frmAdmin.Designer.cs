namespace Gewinnspiel.Forms
{
    partial class frmAdmin
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gewinnspielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einemGewinnspielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvGewinnspiele = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTeilnehmer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAktiv = new System.Windows.Forms.RadioButton();
            this.rbAbgeschlossen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gewinnspielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gewinnspielBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewinnspielHinzufügenToolStripMenuItem,
            this.gewinnspielBearbeitenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 70);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewinnspielToolStripMenuItem,
            this.teilnehmerToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gewinnspielToolStripMenuItem
            // 
            this.gewinnspielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.bearbeitenToolStripMenuItem1});
            this.gewinnspielToolStripMenuItem.Name = "gewinnspielToolStripMenuItem";
            this.gewinnspielToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.gewinnspielToolStripMenuItem.Text = "Gewinnspiel";
            // 
            // teilnehmerToolStripMenuItem
            // 
            this.teilnehmerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerlisteToolStripMenuItem,
            this.hinzufügenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.deaktivierenToolStripMenuItem,
            this.einemGewinnspielHinzufügenToolStripMenuItem});
            this.teilnehmerToolStripMenuItem.Name = "teilnehmerToolStripMenuItem";
            this.teilnehmerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.teilnehmerToolStripMenuItem.Text = "Teilnehmer";
            // 
            // teilnehmerlisteToolStripMenuItem
            // 
            this.teilnehmerlisteToolStripMenuItem.Name = "teilnehmerlisteToolStripMenuItem";
            this.teilnehmerlisteToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.teilnehmerlisteToolStripMenuItem.Text = "Teilnehmerliste";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.bearbeitenToolStripMenuItem.Text = "bearbeiten";
            // 
            // deaktivierenToolStripMenuItem
            // 
            this.deaktivierenToolStripMenuItem.Name = "deaktivierenToolStripMenuItem";
            this.deaktivierenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.deaktivierenToolStripMenuItem.Text = "De/aktivieren";
            // 
            // einemGewinnspielHinzufügenToolStripMenuItem
            // 
            this.einemGewinnspielHinzufügenToolStripMenuItem.Name = "einemGewinnspielHinzufügenToolStripMenuItem";
            this.einemGewinnspielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.einemGewinnspielHinzufügenToolStripMenuItem.Text = "einem Gewinnspiel hinzufügen";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // lvGewinnspiele
            // 
            this.lvGewinnspiele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvGewinnspiele.ContextMenuStrip = this.contextMenuStrip1;
            this.lvGewinnspiele.HideSelection = false;
            this.lvGewinnspiele.Location = new System.Drawing.Point(12, 109);
            this.lvGewinnspiele.Name = "lvGewinnspiele";
            this.lvGewinnspiele.Size = new System.Drawing.Size(595, 359);
            this.lvGewinnspiele.TabIndex = 2;
            this.lvGewinnspiele.UseCompatibleStateImageBehavior = false;
            this.lvGewinnspiele.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bild";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SpielID";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Bezeichnung";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Gewinn";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Wert";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ausgelost";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Bildpfad";
            this.columnHeader16.Width = 120;
            // 
            // lvTeilnehmer
            // 
            this.lvTeilnehmer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvTeilnehmer.HideSelection = false;
            this.lvTeilnehmer.Location = new System.Drawing.Point(639, 109);
            this.lvTeilnehmer.Name = "lvTeilnehmer";
            this.lvTeilnehmer.Size = new System.Drawing.Size(683, 359);
            this.lvTeilnehmer.TabIndex = 3;
            this.lvTeilnehmer.UseCompatibleStateImageBehavior = false;
            this.lvTeilnehmer.View = System.Windows.Forms.View.Details;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAktiv);
            this.groupBox1.Controls.Add(this.rbAbgeschlossen);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbAktiv
            // 
            this.rbAktiv.AutoSize = true;
            this.rbAktiv.Location = new System.Drawing.Point(245, 19);
            this.rbAktiv.Name = "rbAktiv";
            this.rbAktiv.Size = new System.Drawing.Size(121, 17);
            this.rbAktiv.TabIndex = 1;
            this.rbAktiv.TabStop = true;
            this.rbAktiv.Text = "Aktive Gewinnspiele";
            this.rbAktiv.UseVisualStyleBackColor = true;
            // 
            // rbAbgeschlossen
            // 
            this.rbAbgeschlossen.AutoSize = true;
            this.rbAbgeschlossen.Location = new System.Drawing.Point(38, 19);
            this.rbAbgeschlossen.Name = "rbAbgeschlossen";
            this.rbAbgeschlossen.Size = new System.Drawing.Size(169, 17);
            this.rbAbgeschlossen.TabIndex = 0;
            this.rbAbgeschlossen.TabStop = true;
            this.rbAbgeschlossen.Text = "Abgeschlossene Gewinnspiele";
            this.rbAbgeschlossen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teilnehmer des ausgewählten Gewinnspiels";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem1
            // 
            this.bearbeitenToolStripMenuItem1.Name = "bearbeitenToolStripMenuItem1";
            this.bearbeitenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bearbeitenToolStripMenuItem1.Text = "Bearbeiten";
            // 
            // gewinnspielHinzufügenToolStripMenuItem
            // 
            this.gewinnspielHinzufügenToolStripMenuItem.Name = "gewinnspielHinzufügenToolStripMenuItem";
            this.gewinnspielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gewinnspielHinzufügenToolStripMenuItem.Text = "Gewinnspiel hinzufügen";
            this.gewinnspielHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.gewinnspielHinzufügenToolStripMenuItem_Click);
            // 
            // gewinnspielBearbeitenToolStripMenuItem
            // 
            this.gewinnspielBearbeitenToolStripMenuItem.Name = "gewinnspielBearbeitenToolStripMenuItem";
            this.gewinnspielBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gewinnspielBearbeitenToolStripMenuItem.Text = "Gewinnspiel bearbeiten";
            this.gewinnspielBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.gewinnspielBearbeitenToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTeilnehmer);
            this.Controls.Add(this.lvGewinnspiele);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gewinnspielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einemGewinnspielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListView lvGewinnspiele;
        private System.Windows.Forms.ListView lvTeilnehmer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAktiv;
        private System.Windows.Forms.RadioButton rbAbgeschlossen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gewinnspielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gewinnspielBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}