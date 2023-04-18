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
    public partial class AjouteCours : Form
    {
        List<Note> notes = new List<Note>();

        public AjouteCours()
        {
            InitializeComponent();
        }

        private void loadCours()
        {
            listView1.Items.Clear();
            foreach (Note n in notes)
            {
                ListViewItem item = new ListViewItem(n.getNom());
                item.SubItems.Add(n.getNote().ToString());
                item.SubItems.Add(n.getPourcentage().ToString());
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                errorProvider1.SetError(label6, "Veuillez entrer une note !");
            }
            else if (textBox5.Text == "")
            {
                errorProvider1.Clear();
                errorProvider2.SetError(label8, "Veuillez entrer un pourcentage !");
            }
            else if (textBox6.Text == "")
            {
                errorProvider2.Clear();
                errorProvider3.SetError(textBox6, "Veuillez entrer un nom !");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();

                int valeurNote = Int32.Parse(textBox4.Text);
                int valeurPourcentage = Int32.Parse(textBox5.Text);



                Note note = new Note(textBox6.Text, valeurNote, valeurPourcentage);

                notes.Add(note);
                loadCours();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
