using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinforms
{
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            projecteurs authentification = new projecteurs();
            this.Hide();
            authentification.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            enseignant authentification = new enseignant();
            this.Hide();
            authentification.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            administrateur authentification = new administrateur();
            this.Hide();
            authentification.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            eleve authentification = new eleve();
            this.Hide();
            authentification.ShowDialog();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            classe authentification = new classe();
            this.Hide();
            authentification.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            matiere authentification = new matiere();
            this.Hide();
            authentification.ShowDialog();
        }
    }
}
