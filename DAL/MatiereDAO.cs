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
   public class MatiereDAO
    {
        public static bool Insert_matiere(string nom_matiere, string cour, int coef_matiere)
        {
            string requete = String.Format("insert into matiere(nom_matiere,cour,coef_matiere)" +
                " values ('{0}','{1}','{2}');", nom_matiere, cour, coef_matiere);
            return Utils.miseajour(requete);
        }
        public static bool Delete_matiere(string nom_matiere)
        {
            string requete = String.Format("delete from matiere where nom_matiere={0};", nom_matiere);
            return Utils.miseajour(requete);
        }
        public static Matieres Get_matiere(string nom_matiere)
        {
            string requete = String.Format("select * from matiere where nom_matiere={0};", nom_matiere);
            OleDbDataReader rd = Utils.lire(requete);
            Matieres c = new Matieres();
            while (rd.Read())
            {
                c.Nom_matiere = rd.GetString(0);
                c.Cour = rd.GetString(1);
                c.Coeff = rd.GetInt32(2);


            }
            Utils.Disconnect();
            return c;
        }
        public static List<Matieres> Get_matiere()
        {
            string requete = String.Format("select * from matiere;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Matieres> L = new List<Matieres>();
            Matieres c;
            while (rd.Read())
            {
                c = new Matieres
                {
                    Coeff = rd.GetInt32(0),
                    Nom_matiere = rd.GetString(1),
                    Cour = rd.GetString(2),

                };
                L.Add(c);
            }
            Utils.Disconnect();
            return L;
        }

    }
}

