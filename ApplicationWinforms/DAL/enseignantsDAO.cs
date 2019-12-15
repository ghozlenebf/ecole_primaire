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
   public class enseignantsDAO
    {
        public static bool Insert_eleve(string nom_prenom, int cin, int id)
        {
            string requete = String.Format("insert into enseignant(nom_prenom,id,cin)" +
                " values ('{0}','{1}','{2}');", nom_prenom, id, cin);
            return utils.miseajour(requete);
        }

        public static bool Update_eleve(string nom_prenom, int cin, int id)
        {
            string requete = String.Format("updat enseignant set nom_prenom='{0}'," +
                " cin='{2}',id='{3}'  where id={4};", nom_prenom, cin, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_enseignant(int id)
        {
            string requete = String.Format("delete from enseignant where id={0};", id);
            return utils.miseajour(requete);
        }

        public static enseignants Get_enseignant_ID(int id)
        {
            string requete = String.Format("select * from enseignant where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            enseignants c = new enseignants();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.nom_prenom = rd.GetString(1);
                c.cin = rd.GetInt32(2);

            }
            utils.Disconnect();
            return c;
        }

        public static List<enseignants> Get_enseignant()
        {
            string requete = String.Format("select * from enseignant;");
            OleDbDataReader rd = utils.lire(requete);
            List<enseignants> L = new List<enseignants>();
            enseignants c;
            while (rd.Read())
            {
                c = new enseignants
                {
                    id = rd.GetInt32(0),
                    nom_prenom = rd.GetString(1),

                    cin = rd.GetInt32(4),

                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

    }

}
    

