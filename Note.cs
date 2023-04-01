using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyUniversity
{
    class Note
    {
        private string nom;
        private int note;
        private int pourcentage;

        public Note(string nom, int note, int pourcentage)
        {
            this.nom = nom;
            this.note = note;
            this.pourcentage = pourcentage;
        }

        public string getNom()
        {
            return nom;
        }

        public int getNote()
        {
            return note;
        }

        public int getPourcentage()
        {
            return pourcentage;
        }
    }
}
