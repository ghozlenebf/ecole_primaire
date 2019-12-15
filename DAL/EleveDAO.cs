using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
     public class EleveDAO
    {
        public static bool Insert_eleve(string nom, string prenom, string prenom_parent, DateTime date_naissance, int password, int id, string adresse)
        {
            string requete = String.Format("insert into eleve(nom, prenom,prenom_parent,date_naissance,id,password,adresse)" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", nom, prenom, prenom_parent, date_naissance, id, password, adresse);
            return Utils.miseajour(requete);
        }

        public static global::ApplicationWinforms.eleve Get_eleve_ID(object p)
        {
            throw new NotImplementedException();
        }

        public static bool Update_eleve(string nom, string prenom, string prenom_parent, DateTime date_naissance, int password, int id, string adresse)
        {
            string requete = String.Format("update eleve set nom='{0}', prenom={1}," +
                " prenom_parent='{2}',date_naissance='{3}',password='{4}',id='{5}',adresse='{6}' where id={6};", nom, prenom, prenom_parent, date_naissance, password, adresse, id);
            return Utils.miseajour(requete);
        }

        public static bool Delete_eleve(int id)
        {
            string requete = String.Format("delete from eleve   where id={0};", id);
            return Utils.miseajour(requete);
        }

        public static Eleve Get_eleve_ID(int id)
        {
            string requete = String.Format("select * from eleve where id={0};", id);
            OleDbDataReader rd = Utils.lire(requete);
            Eleve c = new Eleve();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.Nom = rd.GetString(1);
                c.Prenom = rd.GetString(2);
                c.Prenom_parent = rd.GetString(3);
                c.Password = rd.GetInt32(4);
                c.Date_naissance = rd.GetDateTime(5);
                c.Adresse = rd.GetString(6);

            }
            Utils.Disconnect();
            return c;
        }

        public static List<Eleve> Get_eleve()
        {
            string requete = String.Format("select * from eleve;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Eleve> L = new List<Eleve>();
            Eleve c;
            while (rd.Read())
            {
                c = new Eleve
                {
                    Id = rd.GetInt32(0),
                    Nom = rd.GetString(1),
                    Prenom = rd.GetString(2),
                    Password = rd.GetInt32(3),
                    Adresse = rd.GetString(4),
                    Prenom_parent = rd.GetString(5),
                    Date_naissance = rd.GetDateTime(6),
                };
                L.Add(c);
            }
            Utils.Disconnect();
            return L;
        }
    }
}

