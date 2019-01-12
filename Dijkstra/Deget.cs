using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti_Dijkstra
{
    class Deget
    {
        public double kosto;
        public int fillestare;
        public int fundit;
        public bool nepeme;
        public Deget(double Kosto, int Fill, int Fund,bool Nepeme)
        {
            kosto = Kosto;
            fillestare = Fill;
            fundit = Fund;
            nepeme = Nepeme;

        }
    }
}
