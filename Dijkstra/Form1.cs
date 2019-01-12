using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projekti_Dijkstra
{
    public partial class Form1 : Form
    {
         Dictionary<int, Koordinatat> objkoor = new Dictionary<int, Koordinatat>();
        List<int> PathiSh = new List<int>();
        static int inf = 1000000;
        double[,] matrica ={ { 0, inf, inf, inf, inf, 50.6, inf, 34, inf, 17.2, 29.1, inf, inf, inf, 29.1},//Prishtine
                                                       { inf, 0, inf, inf, inf, inf, inf, inf,48.4, inf, 12.2, 23.2, inf, inf, 43.5},//Mitrovica 
                                                       { inf, inf, 0, inf, 36, inf, inf, 62,26.3, inf, inf, 51.1, 50.6, inf, inf},//Peja
                                                       { inf, inf, inf, 0, 38.2, inf, inf, inf, inf, inf, inf, inf, inf, 18.2, inf},//Prizren 
                                                       { inf, inf, 36, 38.2, 0, inf, inf, inf, inf, inf, inf, inf, 38.8, 42.6, inf},//Gjakove
                                                       {50.6, inf, inf, inf, inf, 0, 33.9, inf, inf, 39.3, inf, inf, inf, inf, inf},//Gjilan
                                                       { inf, inf, inf, inf, inf, 33.9, 0, inf, inf, 22.7, inf, inf, inf, 42.2, inf},//Ferizaj 
                                                       { 34, inf, 61.8, inf, inf, inf, inf, 0, inf, 35.1, 31.2, 19.2, 25.1, 42.3, inf},//Drenas 
                                                       { inf, 48.4, 26.3, inf, inf, inf, inf, inf, 0, inf, inf, 32.5, inf, inf, inf},//istog
                                                       {17.2, inf, inf, inf, inf, 39.3, 22.7, 35.1, inf, 0, inf, inf, 48.2, 40.8, inf},//Lipjan 
                                                       {29.1, 12.2, inf, inf, inf, inf, inf, 31.2, inf, inf, 0, 22.3, inf, inf, 38.7},//Vushtrri
                                                       { inf, 23.2, 51.1, inf, inf, inf, inf, 19.2, 32.5, inf, 22.3, 0, inf, inf, inf},//Skenderaj
                                                       { inf, inf, 50.6, inf, 38.8, inf, inf, 25.1, inf, 48.2, inf, inf, 0, 23.8, inf},//Malishev
                                                       { inf, inf, inf, 18.2, 42.6, inf, 42.2, 42.3, inf, 40.8, inf, inf, 23.8, 0, inf},//Suharek
                                                       {29.1, 43.5, inf, inf, inf, inf, inf, inf, inf, inf, 38.7, inf, inf, inf, 0},//Podujeve
                                                       };
        double[,] matrica_Shpejtesia ={ { 0, inf, inf, inf, inf, 80, inf,100, inf, 70, 90, inf, inf, inf, 80},//Prishtine 
                                      { inf, 0, inf, inf, inf, inf, inf, inf, 70, inf, 80, 70, inf, inf, 85},//Mitrovica 
                                      { inf, inf, 0, inf, 70, inf, inf,100, 70, inf, inf, 80, 90, inf, inf},//Peja 
                                      { inf, inf, inf, 0, 70, inf, inf, inf, inf, inf, inf, inf, inf,100, inf},//Prizren 
                                      { inf, inf, 70, 70, 0, inf, inf, inf, inf, inf, inf, inf, 80, 90, inf},//Gjakove 
                                      { 80, inf, inf, inf, inf, 0, 70, inf, inf, 80, inf, inf, inf, inf, inf},//Gjilan
                                      { inf, inf, inf, inf, inf, 70, 0, inf, inf, 80, inf, inf, inf, 80, inf},//Ferizaj
                                      {100, inf, 80, inf, inf, inf, inf, 0, inf, 90, 80, 90,100, 80, inf},//Drenas 
                                      { inf, 70,100, inf, inf, inf, inf, inf, 0, inf, inf, 70, inf, inf, inf},//istog
                                      { 70, inf, 70, inf, inf, 80, 100, 80, inf, 0, inf, inf, 80, 80, inf},//Lipjan
                                      { 90, 80, inf, inf, inf, inf, inf, 80, inf, inf, 0, 80, inf, inf, 90},//Vushtrri 
                                      { inf, 70, 80, inf, inf, inf, inf, 90, 70, inf, 80, 0, inf, inf, inf},//Skenderaj                                       
                                      { inf, inf, 90, inf, 80, inf, inf,100, inf, 80, inf, inf, 0, 80, inf},//Malishev
                                      { inf, inf, inf,100, 90, inf, 80, 80, inf, 90, inf, inf, 80, 0, inf},//Suharek
                                      { 80, 85, inf, inf, inf, inf, inf, inf, inf, inf, 90, inf, inf, inf, 0},};//Podujeve
         double[,] matricaKoha = new double[15, 15];
        
        
        
        public Form1()
        {
            InitializeComponent();


            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDestinacioni.SelectedIndex = 0;
            comboBoxQyteti.SelectedIndex = 0;
            for (int i = 0; i < 15; i++)
            {
                for(int j=0;j<15;j++)
                {
                    if (matrica[i, j] != inf  &&matrica[i,j]!=0)
                    {
                        matricaKoha[i, j] =( matrica[i, j] / matrica_Shpejtesia[i, j])*60;
                    }
                    else if(matrica[i,j]==inf)
                    {
                        matricaKoha[i, j] = inf;
                    }
                    else if (matrica[i, j] == 0)
                    {
                        matricaKoha[i, j] = 0;
                    }
                }
            }
            
        }

        private void comboBoxDestinacioni_SelectedIndexChanged(object sender, EventArgs e)
        {








        }

        private void comboBoxQyteti_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtTeksti_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGjeje_Click(object sender, EventArgs e)
        {
            Grafi grafi = new Grafi(matrica);
            grafi.ShtoNyje("Prishtina", 251, 165);
            grafi.ShtoNyje("Mitrovica", 179, 96);
            grafi.ShtoNyje("Peja", 81, 173);
            grafi.ShtoNyje("Prizreni", 150, 289);
            grafi.ShtoNyje("Gjakova", 95, 252);
            grafi.ShtoNyje("Gjilani", 303, 224);
            grafi.ShtoNyje("Ferizaji", 235, 247);
            grafi.ShtoNyje("Drenasi", 182, 189);
            grafi.ShtoNyje("Istog", 117, 141);
            grafi.ShtoNyje("Lipjan", 239, 197);
            grafi.ShtoNyje("Vushtrri", 198, 131);
            grafi.ShtoNyje("Skenderaj", 152, 153);
            grafi.ShtoNyje("Malishevë", 155, 218);
            grafi.ShtoNyje("Suharekë", 177, 248);
            grafi.ShtoNyje("Podujevë", 247, 121);
            objkoor = grafi.DctKoor;
            grafi.Rruga(comboBoxQyteti.SelectedIndex, comboBoxDestinacioni.SelectedIndex);
            txtTeksti.Text = grafi.RrugaMinNgaBurimi(comboBoxDestinacioni.SelectedIndex).ToString()+" km";
            List<int> Pathi = new List<int>();
            grafi.CaktoPathinNga(comboBoxDestinacioni.SelectedIndex, Pathi);
            PathiSh = Pathi;
            txtPathi.Clear();
            for (int i = 0; i < Pathi.Count; i++)
            {
                txtPathi.Text +=grafi.DctNyjet[ Pathi[i]]+" ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPathi.Clear();
            txtShpejtesia.Clear();
            txtTeksti.Clear();
            comboBoxDestinacioni.SelectedIndex = 0;
            comboBoxQyteti.SelectedIndex = 0;
            cmbZgjedh.SelectedIndex = -1;
            objkoor = new Dictionary<int, Koordinatat>();
            panel1.Invalidate();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            objkoor = new Dictionary<int, Koordinatat>();
            panel1.Invalidate();
            if (cmbZgjedh.SelectedIndex == 0)
            {
                txtTeksti.Clear();
                txtTeksti.Visible = false;
                lblRrugaMin.Visible = false;
                btnGjeje.Visible = false; 
                txtShpejtesia.Visible = true;
                lblShpejtesiaMin.Visible = true;
                btnShpejtesiaMIN.Visible = true;
            }
            else if(cmbZgjedh.SelectedIndex==1)
            {
                txtShpejtesia.Clear();
                txtTeksti.Visible = true;
                lblRrugaMin.Visible = true;
                btnGjeje.Visible = true;
                txtShpejtesia.Visible = false;
                lblShpejtesiaMin.Visible = false;
                btnShpejtesiaMIN.Visible = false;
            }
            else if (cmbZgjedh.SelectedIndex == -1)
            {
                txtTeksti.Visible = false;
                lblRrugaMin.Visible = false;
                btnGjeje.Visible = false;
                txtShpejtesia.Visible = false;
                lblShpejtesiaMin.Visible = false;
                btnShpejtesiaMIN.Visible = false;
            }
            txtPathi.Clear();

        }

        private void btnShpejtesiaMIN_Click(object sender, EventArgs e)
        {
            Grafi grafi = new Grafi(matricaKoha);
            grafi.ShtoNyje("Prishtina",251, 165);
            grafi.ShtoNyje("Mitrovica",179, 96);
            grafi.ShtoNyje("Peja",81, 173);
            grafi.ShtoNyje("Prizreni",150, 289);
            grafi.ShtoNyje("Gjakova",95, 252);
            grafi.ShtoNyje("Gjilani",303, 224);
            grafi.ShtoNyje("Ferizaji",235, 247);
            grafi.ShtoNyje("Drenasi",182, 189);
            grafi.ShtoNyje("Istog",117, 141);
            grafi.ShtoNyje("Lipjan",239, 197);
            grafi.ShtoNyje("Vushtrri",198, 131);
            grafi.ShtoNyje("Skenderaj",152, 153);
            grafi.ShtoNyje("Malishevë",155, 218);
            grafi.ShtoNyje("Suharekë",177, 248);
            grafi.ShtoNyje("Podujevë",247, 121);
            objkoor = grafi.DctKoor;
            grafi.Rruga(comboBoxQyteti.SelectedIndex, comboBoxDestinacioni.SelectedIndex);
            List<int> Pathi = new List<int>();
            grafi.CaktoPathinNga(comboBoxDestinacioni.SelectedIndex, Pathi);
            PathiSh = Pathi;
            txtShpejtesia.Text = (grafi.RrugaMinNgaBurimi(comboBoxDestinacioni.SelectedIndex)).ToString()+" minuta";            
            txtPathi.Clear();
            for (int i = 0; i < Pathi.Count; i++)
            {
                txtPathi.Text += grafi.DctNyjet[Pathi[i]] + " ";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (objkoor.Count > 1)
            {

                Graphics g = e.Graphics;
                Pen lapsi = new Pen(Color.Black, 3);
                int numriirrugeve = PathiSh.Count - 1;
                for (int i = 0; i < numriirrugeve; i++)
                {
                    g.DrawLine(lapsi, objkoor[PathiSh[i]].x, objkoor[PathiSh[i]].y, objkoor[PathiSh[i + 1]].x, objkoor[PathiSh[i + 1]].y);
                }
            }
        }
        
        private void btnVizatoPathin_Click(object sender, EventArgs e)
        {

            panel1.Invalidate();
        }

    }
}
