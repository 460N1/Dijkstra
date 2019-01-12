namespace Projekti_Dijkstra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxQyteti = new System.Windows.Forms.ComboBox();
            this.comboBoxDestinacioni = new System.Windows.Forms.ComboBox();
            this.lblQyteti = new System.Windows.Forms.Label();
            this.lbldEST = new System.Windows.Forms.Label();
            this.lblRrugaMin = new System.Windows.Forms.Label();
            this.txtTeksti = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGjeje = new System.Windows.Forms.Button();
            this.txtPathi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShpejtesiaMin = new System.Windows.Forms.Label();
            this.txtShpejtesia = new System.Windows.Forms.TextBox();
            this.btnShpejtesiaMIN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbZgjedh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVizatoPathin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxQyteti
            // 
            this.comboBoxQyteti.FormattingEnabled = true;
            this.comboBoxQyteti.Items.AddRange(new object[] {
            "Prishtinë",
            "Mirtovicë",
            "Pejë",
            "Prizren",
            "Gjakovë",
            "Gjilan",
            "Ferizaj",
            "Drenas\t",
            "Istog",
            "Lipjan",
            "Vushtrri",
            "Skenderaj",
            "Malishevë",
            "Suharekë",
            "Podujev"});
            this.comboBoxQyteti.Location = new System.Drawing.Point(456, 81);
            this.comboBoxQyteti.Name = "comboBoxQyteti";
            this.comboBoxQyteti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQyteti.TabIndex = 0;
            this.comboBoxQyteti.SelectedIndexChanged += new System.EventHandler(this.comboBoxQyteti_SelectedIndexChanged);
            // 
            // comboBoxDestinacioni
            // 
            this.comboBoxDestinacioni.FormattingEnabled = true;
            this.comboBoxDestinacioni.Items.AddRange(new object[] {
            "Prishtinë",
            "Mirtovicë",
            "Pejë",
            "Prizren",
            "Gjakovë",
            "Gjilan",
            "Ferizaj",
            "Drenas\t",
            "Istog",
            "Lipjan",
            "Vushtrri",
            "Skenderaj",
            "Malishevë",
            "Suharekë",
            "Podujev"});
            this.comboBoxDestinacioni.Location = new System.Drawing.Point(456, 132);
            this.comboBoxDestinacioni.Name = "comboBoxDestinacioni";
            this.comboBoxDestinacioni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestinacioni.TabIndex = 1;
            this.comboBoxDestinacioni.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestinacioni_SelectedIndexChanged);
            // 
            // lblQyteti
            // 
            this.lblQyteti.AutoSize = true;
            this.lblQyteti.Location = new System.Drawing.Point(458, 65);
            this.lblQyteti.Name = "lblQyteti";
            this.lblQyteti.Size = new System.Drawing.Size(68, 13);
            this.lblQyteti.TabIndex = 2;
            this.lblQyteti.Text = "Vendi i nisjes";
            // 
            // lbldEST
            // 
            this.lbldEST.AutoSize = true;
            this.lbldEST.Location = new System.Drawing.Point(458, 116);
            this.lbldEST.Name = "lbldEST";
            this.lbldEST.Size = new System.Drawing.Size(65, 13);
            this.lbldEST.TabIndex = 3;
            this.lbldEST.Text = "Destinacioni";
            // 
            // lblRrugaMin
            // 
            this.lblRrugaMin.AutoSize = true;
            this.lblRrugaMin.Location = new System.Drawing.Point(482, 197);
            this.lblRrugaMin.Name = "lblRrugaMin";
            this.lblRrugaMin.Size = new System.Drawing.Size(80, 13);
            this.lblRrugaMin.TabIndex = 4;
            this.lblRrugaMin.Text = "Rruga Minimale";
            this.lblRrugaMin.Visible = false;
            // 
            // txtTeksti
            // 
            this.txtTeksti.Location = new System.Drawing.Point(472, 213);
            this.txtTeksti.Name = "txtTeksti";
            this.txtTeksti.Size = new System.Drawing.Size(100, 20);
            this.txtTeksti.TabIndex = 5;
            this.txtTeksti.Visible = false;
            this.txtTeksti.TextChanged += new System.EventHandler(this.txtTeksti_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(22, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 391);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGjeje
            // 
            this.btnGjeje.Location = new System.Drawing.Point(446, 239);
            this.btnGjeje.Name = "btnGjeje";
            this.btnGjeje.Size = new System.Drawing.Size(158, 23);
            this.btnGjeje.TabIndex = 7;
            this.btnGjeje.Text = "Gjeje Rrugen Minimale";
            this.btnGjeje.UseVisualStyleBackColor = true;
            this.btnGjeje.Visible = false;
            this.btnGjeje.Click += new System.EventHandler(this.btnGjeje_Click);
            // 
            // txtPathi
            // 
            this.txtPathi.Location = new System.Drawing.Point(456, 305);
            this.txtPathi.Multiline = true;
            this.txtPathi.Name = "txtPathi";
            this.txtPathi.Size = new System.Drawing.Size(236, 53);
            this.txtPathi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trajektorja";
            // 
            // lblShpejtesiaMin
            // 
            this.lblShpejtesiaMin.AutoSize = true;
            this.lblShpejtesiaMin.Location = new System.Drawing.Point(465, 197);
            this.lblShpejtesiaMin.Name = "lblShpejtesiaMin";
            this.lblShpejtesiaMin.Size = new System.Drawing.Size(114, 13);
            this.lblShpejtesiaMin.TabIndex = 10;
            this.lblShpejtesiaMin.Text = "Koha minimale e aritjes";
            this.lblShpejtesiaMin.Visible = false;
            // 
            // txtShpejtesia
            // 
            this.txtShpejtesia.Location = new System.Drawing.Point(472, 213);
            this.txtShpejtesia.Name = "txtShpejtesia";
            this.txtShpejtesia.Size = new System.Drawing.Size(100, 20);
            this.txtShpejtesia.TabIndex = 11;
            this.txtShpejtesia.Visible = false;
            // 
            // btnShpejtesiaMIN
            // 
            this.btnShpejtesiaMIN.Location = new System.Drawing.Point(446, 239);
            this.btnShpejtesiaMIN.Name = "btnShpejtesiaMIN";
            this.btnShpejtesiaMIN.Size = new System.Drawing.Size(158, 23);
            this.btnShpejtesiaMIN.TabIndex = 12;
            this.btnShpejtesiaMIN.Text = "Gjej Kohën Minimale te Arrtijes";
            this.btnShpejtesiaMIN.UseVisualStyleBackColor = true;
            this.btnShpejtesiaMIN.Visible = false;
            this.btnShpejtesiaMIN.Click += new System.EventHandler(this.btnShpejtesiaMIN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Përsërit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbZgjedh
            // 
            this.cmbZgjedh.FormattingEnabled = true;
            this.cmbZgjedh.Items.AddRange(new object[] {
            "Rruga më e Shpejtë",
            "Rrugë Minimale"});
            this.cmbZgjedh.Location = new System.Drawing.Point(589, 113);
            this.cmbZgjedh.Name = "cmbZgjedh";
            this.cmbZgjedh.Size = new System.Drawing.Size(134, 21);
            this.cmbZgjedh.TabIndex = 14;
            this.cmbZgjedh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Zgjedh mënyren e udhëtimit";
            // 
            // btnVizatoPathin
            // 
            this.btnVizatoPathin.Location = new System.Drawing.Point(639, 213);
            this.btnVizatoPathin.Name = "btnVizatoPathin";
            this.btnVizatoPathin.Size = new System.Drawing.Size(84, 42);
            this.btnVizatoPathin.TabIndex = 16;
            this.btnVizatoPathin.Text = "Vizato Rrugen";
            this.btnVizatoPathin.UseVisualStyleBackColor = true;
            this.btnVizatoPathin.Click += new System.EventHandler(this.btnVizatoPathin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 466);
            this.Controls.Add(this.btnVizatoPathin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZgjedh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShpejtesiaMIN);
            this.Controls.Add(this.txtShpejtesia);
            this.Controls.Add(this.lblShpejtesiaMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathi);
            this.Controls.Add(this.btnGjeje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTeksti);
            this.Controls.Add(this.lblRrugaMin);
            this.Controls.Add(this.lbldEST);
            this.Controls.Add(this.lblQyteti);
            this.Controls.Add(this.comboBoxDestinacioni);
            this.Controls.Add(this.comboBoxQyteti);
            this.Name = "Form1";
            this.Text = "Kosova Travel Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQyteti;
        private System.Windows.Forms.ComboBox comboBoxDestinacioni;
        private System.Windows.Forms.Label lblQyteti;
        private System.Windows.Forms.Label lbldEST;
        private System.Windows.Forms.Label lblRrugaMin;
        private System.Windows.Forms.TextBox txtTeksti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGjeje;
        private System.Windows.Forms.TextBox txtPathi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShpejtesiaMin;
        private System.Windows.Forms.TextBox txtShpejtesia;
        private System.Windows.Forms.Button btnShpejtesiaMIN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbZgjedh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVizatoPathin;
    }
}

