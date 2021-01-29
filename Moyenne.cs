using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyUniversity
{
    class Moyenne
    {
        private List<Matiere> matieres = new List<Matiere>();

        public List<Matiere> GetMatieres()
        {
            return matieres;
        }
        /*public static bool controleNbMatieres()
        {
            /*try
            {
                int(tb_nbMatieres);

                int nbMatieres = int.TryParse;                
            }
            finally
            {

            };*/
       /*     if (int.TryParse(Formtb_nbMatieres))
            {
                return
            }
        }*/

        public static bool controleNotesMatiere()
        {
            
           /* if ()
            {

            }*/                        
            
            return true;
        }

        public void ajouteMatiere(Matiere mat)
        {
            //Matiere mat = new Matiere();
            matieres.Add(mat);
        }

        public double calculMoyenne()
        {
            double totNotes = 0;
            double totPourc = 0;

            foreach(Matiere mat in matieres)
            {
                totNotes += mat.GetNote()* mat.GetCoef();
                totPourc += mat.GetCoef();
            }

            return Math.Round(totNotes / totPourc, 2);
        }

        public void reset()
        {
            matieres = new List<Matiere>();
        }


    }
}
