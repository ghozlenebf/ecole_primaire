using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Input;
using System.IO;
using System.Reflection;
using BEL;


namespace DAL
{
   public class matierDAO 
    {
        public static bool Insert_matiere(string nom_matiere, string cour, int coef_matiere)
        {
            string requete = String.Format("insert into matiere(nom_matiere,cour,coef_matiere)" +
                " values ('{0}','{1}','{2}');", nom_matiere, cour, coef_matiere);
            return utils.miseajour(requete);
        }
        public static bool Delete_matiere(string nom_matiere)
        {
            string requete = String.Format("delete from matiere where nom_matiere={0};", nom_matiere);
            return utils.miseajour(requete);
        }
        public static matierDAO Get_matiere(string nom_matiere)
        {
            string requete = String.Format("select * from matiere where nom_matiere={0};", nom_matiere);
            OleDbDataReader rd = utils.lire(requete);
            matiere c = new matiere();
            while (rd.Read())
            {
                c.nom_matiere = rd.GetString(0);
                c.cour = rd.GetString(1);
                c.coeff_matiere = rd.GetInt32(2);


            }
            utils.Disconnect();
            return c;
        }
            public static List<matiere> Get_matiere()
            {
                string requete = String.Format("select * from matiere;");
                OleDbDataReader rd = utils.lire(requete);
                List<matiere> L = new List<matiere>();
                matiere c;
                while (rd.Read())
                {
                c = new matiere
                {
                    coeff_matiere = rd.GetInt32(0),
                    nom_matiere = rd.GetString(1),
                    cour = rd.GetString(2),

                };
                    L.Add(c);
                }
                utils.Disconnect();
                return L;
            }

        }
    }
