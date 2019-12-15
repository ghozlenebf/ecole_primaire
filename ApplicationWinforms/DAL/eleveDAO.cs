using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
     public class eleveDAO
    {
        public static bool Insert_eleve(string nom, string prenom, string prenom_parent, DateTime date_naissance, int password, int id, string adresse)
        {
            string requete = String.Format("insert into eleve(nom, prenom,prenom_parent,date_naissance,id,password,adresse)" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", nom, prenom, prenom_parent, date_naissance, id, password, adresse);
            return utils.miseajour(requete);
        }

        public static bool Update_eleve(string nom, string prenom, string prenom_parent, DateTime date_naissance, int password, int id, string adresse)
        {
            string requete = String.Format("update eleve set nom='{0}', prenom={1}," +
                " prenom_parent='{2}',date_naissance='{3}',password='{4}',id='{5}',adresse='{6}' where id={6};", nom, prenom, prenom_parent, date_naissance, password, adresse, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_eleve(int id)
        {
            string requete = String.Format("delete from eleve   where id={0};", id);
            return utils.miseajour(requete);
        }

        public static eleve Get_eleve_ID(int id)
        {
            string requete = String.Format("select * from eleve where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            eleve c = new eleve();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.nom = rd.GetString(1);
                c.prenom = rd.GetString(2);
                c.prenom_parent = rd.GetString(3);
                c.password = rd.GetInt32(4);
                c.date_naissance = rd.GetDateTime(5);
                c.adresse = rd.GetString(6);

            }
            utils.Disconnect();
            return c;
        }

        public static List<eleve> Get_eleve()
        {
            string requete = String.Format("select * from eleve;");
            OleDbDataReader rd = utils.lire(requete);
            List<eleve> L = new List<eleve>();
            eleve c;
            while (rd.Read())
            {
                c = new eleve
                {
                    id = rd.GetInt32(0),
                    nom = rd.GetString(1),
                    prenom = rd.GetString(2),
                    password = rd.GetInt32(3),
                    adresse = rd.GetString(4),
                    prenom_parent = rd.GetString(5),
                    date_naissance = rd.GetDateTime(6),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
    }
}

