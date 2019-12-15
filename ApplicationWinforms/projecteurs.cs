using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BEL;
using DAL;

namespace ApplicationWinforms
{
    public partial class projecteurs : Form
    {
        public projecteurs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProjecteursDAO.Delete_projecteur(int.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb  ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select etat from matiere where etat=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox4.Text = rd.GetInt32(2).ToString();
                textBox3.Text = rd.GetInt32(3).ToString();

                break;


            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id_projecteur from projecteur where id_projecteur=textBox2.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox4.Text = rd.GetInt32(2).ToString();
               

                break;


            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                projecteurs prj = Projecteurs.Get_projecteur(int.Parse(textBox4.Text));
               
                textBox4.Text = prj.(int.Parse(textBox4.Text));

                List<projecteurs> L = new List<projecteurs>
                {
                    prj
                };
                grid_projecteurs.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id_projecteur from projecteur where id_projecteur=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox4.Text = rd.GetInt32(2).ToString();


                break;


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<projecteurs> Listprojecteur = Projecteurs.Get_projecteur();
                grid_projecteurs.DataSource = Listprojecteur;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                ProjecteursDAO.Insert_projecteur(textBox4.Text,int.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
