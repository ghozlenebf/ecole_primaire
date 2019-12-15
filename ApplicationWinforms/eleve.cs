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
    public partial class eleve : Form
    {
        public eleve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                eleve elv = eleveDAO.Get_eleve_ID(int.(textBox3.Text));
                textBox1.Text = elv.(textBox1.Text);
                textBox2.Text = elv.(textBox2.Text);
                textBox3.Text = elv.(textBox3.Text);
                textBox4.Text = elv.(textBox4.Text);
                textBox5.Text = elv.(textBox5.Text);
                textBox6.Text = elv.(textBox6.Text);
              
                textBox8.Text = elv.(textBox8.Text);
                List<eleve> L = new List<eleve>();
                L.Add(elv);
                grid_eleves.DataSource = L;
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
                List<eleve> Listeleve = eleveDAO.Get_eleve_ID(int.Parse(textBox3.Text);
                grid_eleves.DataSource = Listeleve;
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
                eleveDAO.Delete_eleve(int.Parse(textBox9.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select nom from eleve where nom=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select prenom from eleve where prenom =textBox2.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id  from eleve where id=int(textBox3.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
           
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select prenom_parent from eleve where prenom_parent=textBox5.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select password from eleve where password = int(textBox6.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select date_naissance from eleve where date_naissance=textBox4.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
               
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select  from eleve where nom=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void eleve_Load(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select adresse from eleve where adresse=textBox8.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
              
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DELL\\Desktop\\kallel\\ecole primaire.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id from eleve where id=int(textBox9.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetString(1);
                textBox3.Text = rd.GetInt32(2).ToString();
                textBox4.Text = rd.GetString(3);
                textBox5.Text = rd.GetInt32(4).ToString();
                textBox6.Text = rd.GetString(5);
               
                textBox8.Text = rd.GetString(7);
                break;


            }
            cn.Close();
        }
    }
}
