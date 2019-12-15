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
using System.IO;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class enseignant : Form
    {
        public enseignant()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                enseignants ensg = enseignantsDAO.Get_enseignant_ID(int.Parse(textBox1.Text));
                textBox1.Text = ensg.(int.Parse(id));
                textBox7.Text = ensg.nom_prenom;
                textBox3.Text = ensg.(int.Parse(enseignants.cin));
                List<administrateursDAO> L = new List<administrateursDAO>();
                L.Add(ensg);
                grid_enseignant.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<enseignant> Listenseignant = enseignantsDAO.Get_enseignant_ID(int.(textBox1.Text);
                grid_enseignant.DataSource = Listenseignant;
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
                enseignantsDAO.Delete_enseignant(int.(textBox5.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select nom_prenom from enseignant where nom_prenom = textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox7.Text = rd.GetString(1);
                textBox3.Text = rd.GetString(2);

                break;


            }
            cn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id from enseignant where id =int(textBox3.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox7.Text = rd.GetString(1);
                textBox3.Text = rd.GetString(2);

                break;


            }
            cn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select cin from enseignant where cin = int(textBox7.Text);");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox7.Text = rd.GetString(1);
                textBox3.Text = rd.GetString(2);

                break;


            }
            cn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id from enseignant where id = int(textBox5.Text);");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox7.Text = rd.GetString(1);
                textBox3.Text = rd.GetString(2);

                break;


            }
            cn.Close();
        }

        private void grid_enseignant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } }
