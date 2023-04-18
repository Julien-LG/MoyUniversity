using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyUniversity
{
    public partial class Form1 : Form
    {
        Moyenne moy = new Moyenne();
        int nbMatieres;
        int numeroMatiere = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public void actualiseList()
        {
            listView1.Items.Clear();
            //moy.GetMatieres();
            foreach(Matiere mat in moy.GetMatieres())
            {
                //listView1.Columns.Add(Matière);
                var row = new string[] { mat.GetNom(), mat.GetNote().ToString(), mat.GetCoef().ToString() };
                var lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
            }
            
        }

        public void resetPanel()
        {
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (TextBox tb in pnl.Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                }
            }
        }

        //Ajoute une note
        private void bt_ajouterMatiere_Click(object sender, EventArgs e)
        {
            // LES CONTROLES DE SECURITE POUR EVITER LES crash
            //Moyenne.ajouteMatiere();

            //Ajoute un "0" dans les textBox vides
            /*foreach (Control tb in this.Controls)
            {
                if (tb is TextBox)
                {
                    //Console.WriteLine(tb.Name);
                    richTextBox1.Text += tb.Name + "\n";
                    if (tb.Text == string.Empty)
                    {
                        tb.Text = "0";
                    }
                }
            }*/

            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                foreach (TextBox tb in pnl.Controls.OfType<TextBox>())
                {
                    //richTextBox1.Text += tb.Name + "\n";
                    /*if (string.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        //MessageBox.Show("Text box can't be empty");
                        
                    }*/
                    if (tb.Text == string.Empty)
                    {
                        tb.Text = "0";
                    }
                }
            }

            
            //Calcul la moyenne avec les pourcentages et les notes
            double moyenneMatiere = int.Parse(tb_note1.Text) * int.Parse(tb_pourc1.Text) + int.Parse(tb_note2.Text) * int.Parse(tb_pourc2.Text) + int.Parse(tb_note3.Text) * int.Parse(tb_pourc3.Text) + int.Parse(tb_note4.Text) * int.Parse(tb_pourc4.Text) + int.Parse(tb_note5.Text) * int.Parse(tb_pourc5.Text);
            moyenneMatiere = moyenneMatiere / 100;
            
                
            moy.ajouteMatiere(new Matiere(tb_nomMatiere.Text, moyenneMatiere, double.Parse(tb_coefMatiere.Text)));
            //moy.GetMatieres();
            actualiseList();
            resetPanel();
            //int.Parse(tb_nbNote.Text) + 1).ToString()
            /*int fdp = int.Parse(tb_nbNote.Text);
            tb_nbNote.Text = (fdp + 1).ToString();*/
            //richTextBox1.Text = tb_nbNote.Text;

            numeroMatiere += 1;
            tb_nbNote.Text = numeroMatiere.ToString();

            if (listView1.Items.Count == nbMatieres)
            {
                pnl1.Visible = false;
                bt_ajouterMatiere.Visible = false;
                tb_moyenne.Text = moy.calculMoyenne().ToString();
                richTextBox1.Text = moy.calculMoyenne().ToString();
                numeroMatiere = 1;
                tb_nbNote.Text = numeroMatiere.ToString();
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            int nb = 0;
            if (int.TryParse(tb_nbMatieres.Text, out nb))
            {
                nbMatieres = nb;
                pnl1.Visible = true;
                bt_ajouterMatiere.Visible = true;
                listView1.Items.Clear();
            }
            else
            {
                pnl1.Visible = false;
                bt_ajouterMatiere.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetPanel();
            listView1.Items.Clear();
            tb_nbMatieres.Text = "";
            nbMatieres = 0;
            pnl1.Visible = false;
            bt_ajouterMatiere.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
