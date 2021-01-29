using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyUniversity
{
    class Matiere
    {
        private string nom;
        private double note;
        private double coef;

        public Matiere(string nom, double note, double coef)
        {
            this.nom = nom;
            this.note = note;
            this.coef = coef;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public double GetNote()
        {
            return this.note;
        }

        public double GetCoef()
        {
            return this.coef;
        }

        /*public Matiere(string nom, string note1, string note2, string note3, string note4, string note5, string pourc1, string pourc2, string pourc3, string pourc4, string pourc5, int coef)
        {
            double note = 0;
            try
            {
                int n1 = int.Parse(note1)
            }
            finally
            {

            }

            this();
        }*/

    }
}
