using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using DAL;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class matiere : Form
    {
        public matiere()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select nom_matiere from matiere where nom_matiere=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                
                break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                matieres matr= matiereDAO.Get_matiere(textBox1.Text);
                textBox1.Text = matr.(textBox1.Text);
                textBox2.Text = matr.(textBox2.Text);
                textBox3.Text = matr.(textBox3.Text);
               
               
                List<matieres> L = new List<matieres>();
                L.Add(matr);
                grid_matieres.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<matiereDAO> Listmatiere = matiereDAO.Get_matiere(int.(textBox1.Text));
                grid_matieres.DataSource = Listmatiere;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                matiereDAO.Delete_matiere(textBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select cour from matiere where cour =textBox2.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                
                break;


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select coeff_matiere from matiere where coeff_matiere =int(textBox3.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
               
                break;


            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select nom_matiere from matiere where nom_matiere=textBox4.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
               
                break;


            }
        }
    }
}
