using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyUniversity
{
    class Cours
    {
        private string nom;
        private int nbECTS;
        private List<Note> listeNotes;

        public Cours(string nom, int nbECTS, List<Note> listeNotes)
        {
            this.nom = nom;
            this.nbECTS = nbECTS;
            this.listeNotes = listeNotes;
        }

        public string getNom()
        {
            return nom;
        }

        public int getECTS()
        {
            return nbECTS;
        }

        public List<Note> GetNotes()
        {
            return listeNotes;
        }

        public int nbNotes()
        {
            return listeNotes.Count();
        }

        //public void add

        public float moyenneCours()
        {
            float total = 0;
            foreach(Note n in listeNotes)
            {
                //total += n.getNote();
                total += n.getNote() * (n.getPourcentage() / 100);
            }
            return total;
            //return total / nbNotes();
        }
    }
}
