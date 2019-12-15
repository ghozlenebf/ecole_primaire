using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;
using System.IO;
using System.Reflection;

namespace DAL
{
   public class EnseignantsDAO
    {
        public static bool Insert_eleve(string nom_prenom, int cin, int id)
        {
            string requete = String.Format("insert into enseignant(nom_prenom,id,cin)" +
                " values ('{0}','{1}','{2}');", nom_prenom, id, cin);
            return Utils.miseajour(requete);
        }

        public static bool Update_eleve(string nom_prenom, int cin, int id)
        {
            string requete = String.Format("updat enseignant set nom_prenom='{0}'," +
                " cin='{2}',id='{3}'  where id={4};", nom_prenom, cin, id);
            return Utils.miseajour(requete);
        }

        public static bool Delete_enseignant(int id)
        {
            string requete = String.Format("delete from enseignant where id={0};", id);
            return Utils.miseajour(requete);
        }

        public static Enseignants Get_enseignant_ID(int id)
        {
            string requete = String.Format("select * from enseignant where id={0};", id);
            OleDbDataReader rd = Utils.lire(requete);
            Enseignants c = new Enseignants();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.Nom_prenom = rd.GetString(1);
                c.CIN = rd.GetInt32(2);

            }
            Utils.Disconnect();
            return c;
        }

        public static List<Enseignants> Get_enseignant()
        {
            string requete = String.Format("select * from enseignant;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Enseignants> L = new List<Enseignants>();
            Enseignants c;
            while (rd.Read())
            {
                c = new Enseignants
                {
                    Id = rd.GetInt32(0),
                    Nom_prenom = rd.GetString(1),

                    CIN = rd.GetInt32(4),

                };
                L.Add(c);
            }
            Utils.Disconnect();
            return L;
        }

    }

}
    

