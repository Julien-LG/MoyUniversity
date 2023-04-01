using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyUniversity
{
    class Bloc
    {
        private string nom;
        private bool importante;
        private List<Cours> listeCours;

        public Bloc(string nom, bool importante, List<Cours> listeCours)
        {
            this.nom = nom;
            this.importante = importante;
            this.listeCours = listeCours;
        }

        public string getNom()
        {
            return nom;
        }

        public List<Cours> GetCours()
        {
            return listeCours;
        }

        public void setCours(List<Cours>  listeCours)
        {
            this.listeCours = listeCours;
        }

        public int getNbECTS()
        {
            int total = 0;
            foreach(Cours c in listeCours)
            {
                total += c.getECTS();
            }
            return total;
        }
    }
}
