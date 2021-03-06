﻿namespace form
{
    partial class Form1
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
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.lKontinenti = new System.Windows.Forms.Label();
            this.lSortirajpo = new System.Windows.Forms.Label();
            this.comboBoxSortiraj = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lPretrazi = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPretrazi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSpremi = new System.Windows.Forms.Button();
            this.tbKontinent = new System.Windows.Forms.TextBox();
            this.tbPovršina = new System.Windows.Forms.TextBox();
            this.tbBrojStanovnika = new System.Windows.Forms.TextBox();
            this.tbGlavniGrad = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.laKontinent = new System.Windows.Forms.Label();
            this.laPovršina = new System.Windows.Forms.Label();
            this.laBrojStanovnika = new System.Windows.Forms.Label();
            this.laGlavniGrad = new System.Windows.Forms.Label();
            this.laNaziv = new System.Windows.Forms.Label();
            this.laKod = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCountries.Location = new System.Drawing.Point(230, 6);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(651, 443);
            this.dataGridViewCountries.TabIndex = 0;
            this.dataGridViewCountries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountries_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sCode";
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sName";
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sCapital";
            this.Column3.HeaderText = "Glavni grad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nPopulation";
            this.Column4.HeaderText = "Populacija";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fArea";
            this.Column5.HeaderText = "Površina";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sRegion";
            this.Column6.HeaderText = "Kontinent";
            this.Column6.Name = "Column6";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(33, 50);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(151, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // lKontinenti
            // 
            this.lKontinenti.AutoSize = true;
            this.lKontinenti.Location = new System.Drawing.Point(30, 34);
            this.lKontinenti.Name = "lKontinenti";
            this.lKontinenti.Size = new System.Drawing.Size(54, 13);
            this.lKontinenti.TabIndex = 2;
            this.lKontinenti.Text = "Kontinenti";
            // 
            // lSortirajpo
            // 
            this.lSortirajpo.AutoSize = true;
            this.lSortirajpo.Location = new System.Drawing.Point(33, 78);
            this.lSortirajpo.Name = "lSortirajpo";
            this.lSortirajpo.Size = new System.Drawing.Size(54, 13);
            this.lSortirajpo.TabIndex = 3;
            this.lSortirajpo.Text = "Sortiraj po";
            // 
            // comboBoxSortiraj
            // 
            this.comboBoxSortiraj.FormattingEnabled = true;
            this.comboBoxSortiraj.Location = new System.Drawing.Point(33, 95);
            this.comboBoxSortiraj.Name = "comboBoxSortiraj";
            this.comboBoxSortiraj.Size = new System.Drawing.Size(151, 21);
            this.comboBoxSortiraj.TabIndex = 4;
            this.comboBoxSortiraj.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortiraj_SelectedIndexChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(110, 162);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lPretrazi
            // 
            this.lPretrazi.AutoSize = true;
            this.lPretrazi.Location = new System.Drawing.Point(31, 120);
            this.lPretrazi.Name = "lPretrazi";
            this.lPretrazi.Size = new System.Drawing.Size(42, 13);
            this.lPretrazi.TabIndex = 7;
            this.lPretrazi.Text = "Pretraži";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 484);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPretrazi);
            this.tabPage1.Controls.Add(this.dataGridViewCountries);
            this.tabPage1.Controls.Add(this.lPretrazi);
            this.tabPage1.Controls.Add(this.comboBoxSortiraj);
            this.tabPage1.Controls.Add(this.btnPretrazi);
            this.tabPage1.Controls.Add(this.comboBoxRegion);
            this.tabPage1.Controls.Add(this.lKontinenti);
            this.tabPage1.Controls.Add(this.lSortirajpo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pregled";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbPretrazi
            // 
            this.tbPretrazi.Location = new System.Drawing.Point(33, 137);
            this.tbPretrazi.Name = "tbPretrazi";
            this.tbPretrazi.Size = new System.Drawing.Size(151, 20);
            this.tbPretrazi.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSpremi);
            this.tabPage2.Controls.Add(this.tbKontinent);
            this.tabPage2.Controls.Add(this.tbPovršina);
            this.tabPage2.Controls.Add(this.tbBrojStanovnika);
            this.tabPage2.Controls.Add(this.tbGlavniGrad);
            this.tabPage2.Controls.Add(this.tbNaziv);
            this.tabPage2.Controls.Add(this.tbKod);
            this.tabPage2.Controls.Add(this.laKontinent);
            this.tabPage2.Controls.Add(this.laPovršina);
            this.tabPage2.Controls.Add(this.laBrojStanovnika);
            this.tabPage2.Controls.Add(this.laGlavniGrad);
            this.tabPage2.Controls.Add(this.laNaziv);
            this.tabPage2.Controls.Add(this.laKod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSpremi
            // 
            this.bSpremi.Location = new System.Drawing.Point(52, 224);
            this.bSpremi.Name = "bSpremi";
            this.bSpremi.Size = new System.Drawing.Size(155, 30);
            this.bSpremi.TabIndex = 12;
            this.bSpremi.Text = "SPREMI";
            this.bSpremi.UseVisualStyleBackColor = true;
            this.bSpremi.Click += new System.EventHandler(this.bSpremi_Click);
            // 
            // tbKontinent
            // 
            this.tbKontinent.Location = new System.Drawing.Point(107, 180);
            this.tbKontinent.Name = "tbKontinent";
            this.tbKontinent.Size = new System.Drawing.Size(100, 20);
            this.tbKontinent.TabIndex = 11;
            // 
            // tbPovršina
            // 
            this.tbPovršina.Location = new System.Drawing.Point(108, 152);
            this.tbPovršina.Name = "tbPovršina";
            this.tbPovršina.Size = new System.Drawing.Size(100, 20);
            this.tbPovršina.TabIndex = 10;
            // 
            // tbBrojStanovnika
            // 
            this.tbBrojStanovnika.Location = new System.Drawing.Point(108, 122);
            this.tbBrojStanovnika.Name = "tbBrojStanovnika";
            this.tbBrojStanovnika.Size = new System.Drawing.Size(100, 20);
            this.tbBrojStanovnika.TabIndex = 9;
            // 
            // tbGlavniGrad
            // 
            this.tbGlavniGrad.Location = new System.Drawing.Point(108, 93);
            this.tbGlavniGrad.Name = "tbGlavniGrad";
            this.tbGlavniGrad.Size = new System.Drawing.Size(100, 20);
            this.tbGlavniGrad.TabIndex = 8;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(108, 61);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 7;
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(108, 29);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(100, 20);
            this.tbKod.TabIndex = 6;
            // 
            // laKontinent
            // 
            this.laKontinent.AutoSize = true;
            this.laKontinent.Location = new System.Drawing.Point(49, 183);
            this.laKontinent.Name = "laKontinent";
            this.laKontinent.Size = new System.Drawing.Size(52, 13);
            this.laKontinent.TabIndex = 5;
            this.laKontinent.Text = "Kontinent";
            // 
            // laPovršina
            // 
            this.laPovršina.AutoSize = true;
            this.laPovršina.Location = new System.Drawing.Point(53, 155);
            this.laPovršina.Name = "laPovršina";
            this.laPovršina.Size = new System.Drawing.Size(48, 13);
            this.laPovršina.TabIndex = 4;
            this.laPovršina.Text = "Površina";
            // 
            // laBrojStanovnika
            // 
            this.laBrojStanovnika.AutoSize = true;
            this.laBrojStanovnika.Location = new System.Drawing.Point(21, 125);
            this.laBrojStanovnika.Name = "laBrojStanovnika";
            this.laBrojStanovnika.Size = new System.Drawing.Size(80, 13);
            this.laBrojStanovnika.TabIndex = 3;
            this.laBrojStanovnika.Text = "Broj stanovnika";
            // 
            // laGlavniGrad
            // 
            this.laGlavniGrad.AutoSize = true;
            this.laGlavniGrad.Location = new System.Drawing.Point(40, 96);
            this.laGlavniGrad.Name = "laGlavniGrad";
            this.laGlavniGrad.Size = new System.Drawing.Size(61, 13);
            this.laGlavniGrad.TabIndex = 2;
            this.laGlavniGrad.Text = "Glavni grad";
            // 
            // laNaziv
            // 
            this.laNaziv.AutoSize = true;
            this.laNaziv.Location = new System.Drawing.Point(67, 65);
            this.laNaziv.Name = "laNaziv";
            this.laNaziv.Size = new System.Drawing.Size(34, 13);
            this.laNaziv.TabIndex = 1;
            this.laNaziv.Text = "Naziv";
            // 
            // laKod
            // 
            this.laKod.AutoSize = true;
            this.laKod.Location = new System.Drawing.Point(75, 33);
            this.laKod.Name = "laKod";
            this.laKod.Size = new System.Drawing.Size(26, 13);
            this.laKod.TabIndex = 0;
            this.laKod.Text = "Kod";
            this.laKod.Click += new System.EventHandler(this.laKod_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(905, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Karta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(905, 458);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.openstreetmap.org", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "REST Countries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label lKontinenti;
        private System.Windows.Forms.Label lSortirajpo;
        private System.Windows.Forms.ComboBox comboBoxSortiraj;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label laKontinent;
        private System.Windows.Forms.Label laPovršina;
        private System.Windows.Forms.Label laBrojStanovnika;
        private System.Windows.Forms.Label laGlavniGrad;
        private System.Windows.Forms.Label laNaziv;
        private System.Windows.Forms.Label laKod;
        private System.Windows.Forms.Button bSpremi;
        private System.Windows.Forms.TextBox tbKontinent;
        private System.Windows.Forms.TextBox tbPovršina;
        private System.Windows.Forms.TextBox tbBrojStanovnika;
        private System.Windows.Forms.TextBox tbGlavniGrad;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tbPretrazi;
    }
}

