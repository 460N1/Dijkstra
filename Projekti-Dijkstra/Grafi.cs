using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti_Dijkstra
{
    class Grafi
    {
        int max_nyjet = 15;
        double[,] matrica;
        int infinit = 1000000;
        Nyja[] nyjet;//Lista e nyjeve        
        int indeks_nyja;
        int nyjafill;
        int indeks_Pema;
        Distanca[] rruga_Min;
        public Dictionary<int, string> DctNyjet = new Dictionary<int, string>();
        public Dictionary<int, Koordinatat> DctKoor = new Dictionary<int, Koordinatat>();
        int nyja_aktive;
        double distanaca_aktuale;
        public Grafi(double[,] Matrica)
        {
            matrica = new double[max_nyjet, max_nyjet];
            nyjet = new Nyja[max_nyjet];
            indeks_nyja = 0;
            indeks_Pema = 0;
            matrica = Matrica;
            rruga_Min = new Distanca[max_nyjet];
        }
        public void ShtoNyje(string qyteti,int x,int y)
        {
            Koordinatat koor = new Koordinatat(x, y);
            DctKoor.Add(indeks_nyja, koor);
            nyjet[indeks_nyja] = new Nyja(qyteti);
            DctNyjet.Add(indeks_nyja, qyteti);
            indeks_nyja++;
        }
        public void Rruga(int nyja_fillestare, int nyja_fundit)
        {
            
            nyjafill = nyja_fillestare;
            indeks_Pema = 0;
            for (int i = 0; i < indeks_nyja; i++)
            {
                if (i == nyja_fillestare)
                {
                    rruga_Min[i] = new Distanca(nyja_fillestare, 0);
                }
                else
                {
                    rruga_Min[i] = new Distanca(nyja_fillestare, infinit);
                }
            }
            if (nyja_fillestare == nyja_fundit) return;
            while (indeks_Pema < indeks_nyja)
            {
                nyja_aktive = Gjeje_Minimumin();
                distanaca_aktuale = rruga_Min[nyja_aktive].distanca;
                List<int> lista = GjejiNyjetFqinje(nyja_aktive);
                for (int i = 0; i < lista.Count; i++)
                {
                    double Distanca = distanaca_aktuale + matrica[nyja_aktive, lista[i]];
                    if (rruga_Min[lista[i]].distanca != infinit)// a ka ndonje rruge qe kalon deri te ajo nyje e i te me e afert
                    {
                        if (Distanca < rruga_Min[lista[i]].distanca)//nese po a eshte me e vogla
                        {
                            nyjet[lista[i]].nyjaparaprake = nyja_aktive;
                        }
                    }
                    else//perndryshe merre si te paravizituar nyjen minimale aktuale 
                    {
                        nyjet[lista[i]].nyjaparaprake = nyja_aktive;
                    }
                }
                nyjet[nyja_aktive].eVizituar = true;
                indeks_Pema++;
                if (nyjet[nyja_fundit].eVizituar == true)
                {
                    break;
                }
                Azhurno();
            }
        }
        public List<int> GjejiNyjetFqinje(int nyja)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < indeks_nyja; i++)
            {
                if (matrica[nyja, i] != infinit && matrica[nyja_aktive, i] != 0 && !nyjet[i].eVizituar)
                {
                    lista.Add(i);
                }
            }
            return lista;
        }
        public double RrugaMinNgaBurimi(int indeksnyja)
        {
            return rruga_Min[indeksnyja].distanca;
        }
        public void Azhurno()
        {
            for (int i = 0; i < indeks_nyja; i++)
            {
                if (!nyjet[i].eVizituar && matrica[nyja_aktive, i] != infinit && distanaca_aktuale + matrica[nyja_aktive, i] < rruga_Min[i].distanca)
                {
                    rruga_Min[i].distanca = distanaca_aktuale + matrica[nyja_aktive, i];
                }
            }
        }
        public void CaktoPathinNga(int destinacioni, List<int> Pathi)
        {
            int nyjaktuale = destinacioni;
            while (nyjafill != nyjaktuale)
            {
                int temp = nyjaktuale;
                Pathi.Insert(0, temp);
                nyjaktuale = nyjet[nyjaktuale].nyjaparaprake;
            }
            Pathi.Insert(0, nyjafill);
        }
        public int Gjeje_Minimumin()
        {
            double distanca_minimale = infinit;
            int indeksi_min = 0;
            for (int i = 0; i < indeks_nyja; i++)
            {
                if ((nyjet[i].eVizituar == false) && (rruga_Min[i].distanca < distanca_minimale))
                {
                    distanca_minimale = rruga_Min[i].distanca;
                    indeksi_min = i;
                }
            }
            return indeksi_min;
        }
    }
}
