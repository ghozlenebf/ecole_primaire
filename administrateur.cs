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
using System.IO;
using System.Reflection;

namespace ApplicationWinforms
{
    public partial class administrateur : Form
    {
        public administrateur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id  from administrateur where id=int(textBox1.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetInt32(1).ToString();

                break;
            }
            cn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select password  from administrateur where password=int(textBox2.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetInt32(0).ToString();
                textBox2.Text = rd.GetInt32(1).ToString();
                
                break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                administrateursDAO adm = administrateursDAO.Get_administrateur_ID(int.(textBox1.Text));
                textBox1.Text = adm.(textBox1.Text);
                textBox2.Text = adm.(textBox2.Text);
               
                List<administrateursDAO> L = new List<administrateursDAO>();
                L.Add(adm);
                grid_administrateurs.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
