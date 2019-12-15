﻿using System;
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
    public partial class classe : Form
    {
        public classe()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select nom_classe from projecteur where nom_classe=textBox1.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox5.Text = rd.GetInt32(2).ToString();
                textBox2.Text = rd.GetInt32(3).ToString();



                break;


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                classesDAO cls = classesDAO.Get_classe(int.(textBox2.Text));

                textBox4.Text = cls.(int.Parse(textBox2.Text));

                List<classesDAO> L = new List<classesDAO>();
                L.Add(cls);
                grid_classes.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<classe> Listclasse = classesDAO.Get_classe(TextBox.(int.Parse(textBox2.Text)));
               
                grid_classes.DataSource = Listclasse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                classesDAO.Insert_classe(textBox1.Text, int.Parse(textBox5.Text),int.Parse(textBox2.Text));
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
                classesDAO.Delete_classe(int.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id_classe from classe where id_classe=textBox2.Text ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox2.Text = rd.GetInt32(2).ToString();
                textBox5.Text = rd.GetInt32(3).ToString();


                break;


            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select niveau from classe where niveau=int.(textBox5.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox5.Text = rd.GetInt32(2).ToString();
                textBox2.Text = rd.GetInt32(3).ToString();


                break;


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string c = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ASUS\\Desktop\\TP4\\Bien.accdb ;";
            OleDbConnection cn = new OleDbConnection(c);
            cn.Open();
            string req = string.Format("select id_projecteur from projecteur where id_projecteur=int.(textBox2.Text) ;");
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                textBox1.Text = rd.GetString(0);
                textBox4.Text = rd.GetInt32(2).ToString();


                break;


            }

        }
    }
}
