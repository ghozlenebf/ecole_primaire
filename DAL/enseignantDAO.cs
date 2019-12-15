using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class enseignantDAO
    {
        public static bool Insert_eleve(string nom, string prenom, string mail,  int password, int id)
        {
            string requete = String.Format("insert into enseignant(nom, prenom,mail,id,password)" +
                " values ('{0}','{1}','{2}','{3}','{4}');", nom, prenom, mail, id, password);
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

        public static enseignant Get_enseignant_ID(int id)
        {
            string requete = String.Format("select * from enseignant where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            enseignant c = new enseignant();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.nom_prenom = rd.GetString(1);
                c.cin = rd.GetInt32(2);

            }
            utils.Disconnect();
            return c;
        }

        public static List<enseignant> Get_enseignant()
        {
            string requete = String.Format("select * from enseignant;");
            OleDbDataReader rd = utils.lire(requete);
            List<enseignant> L = new List<enseignant>();
            enseignant c;
            while (rd.Read())
            {
                c = new enseignant
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

