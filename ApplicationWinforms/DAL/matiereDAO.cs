using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;
using System.Reflection;
using System.IO;

namespace DAL
{
   public class matiereDAO
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
        public static matieres Get_matiere(string nom_matiere)
        {
            string requete = String.Format("select * from matiere where nom_matiere={0};", nom_matiere);
            OleDbDataReader rd = utils.lire(requete);
            matieres c = new matieres();
            while (rd.Read())
            {
                c.nom_matiere = rd.GetString(0);
                c.cour = rd.GetString(1);
                c.coeff = rd.GetInt32(2);


            }
            utils.Disconnect();
            return c;
        }
        public static List<matieres> Get_matiere()
        {
            string requete = String.Format("select * from matiere;");
            OleDbDataReader rd = utils.lire(requete);
            List<matieres> L = new List<matieres>();
            matieres c;
            while (rd.Read())
            {
                c = new matieres
                {
                    coeff = rd.GetInt32(0),
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

