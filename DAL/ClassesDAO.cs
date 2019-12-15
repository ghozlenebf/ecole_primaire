using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
   public class ClassesDAO
    {
        public static bool Insert_classe(string nom_classe, int niveau, int id_classe)
        {
            string requete = String.Format("insert into classe(nom_classe,niveau,id_classe)" +
                " values ('{0}','{1}','{2}');", nom_classe, niveau, id_classe);
            return Utils.miseajour(requete);
        }
        public static bool Delete_classe(int id_classe)
        {
            string requete = String.Format("delete from classe where id_classe={0};", id_classe);
            return Utils.miseajour(requete);
        }
        public static Classes Get_classe(int id_classe)
        {
            string requete = String.Format("select * from classe where id_classe={0};", id_classe);
            OleDbDataReader rd = Utils.lire(requete);
            Classes c = new Classes();
            while (rd.Read())
            {
                c.Nom_classe = rd.GetString(0);
                c.Niveau = rd.GetInt32(1);
                c.Id_classe = rd.GetInt32(2);


            }
            Utils.Disconnect();
            return c;
        }
        public static List<Classes> Get_classe()

        {
            string requete = String.Format("select * from classe;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Classes> L = new List<Classes>();
            Classes c;
            while (rd.Read())
            {
                c = new Classes
                {
                    Niveau = rd.GetInt32(0),
                    Nom_classe = rd.GetString(1),
                    Id_classe = rd.GetInt32(2),

                };
                L.Add(c);

            }
            Utils.Disconnect();
            return L;
        }

    }
}

