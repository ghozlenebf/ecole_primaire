using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;
using System.Windows;

namespace DAL
{
   public class administrateurDAO
    {
        public static bool Insert_administrateur(  int password, int id)
        {
            string requete = String.Format("insert into administrateur(id,password)" +
                " values ('{0}','{1}');",  id, password);
            return utils.miseajour(requete);
        }

        public static bool Update_administrateur( int password, int id)
        {
            string requete = String.Format("updat administrateur set"  +
               "password='{0}',id='{1}'  where id={6};",password, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_administrateur(int id)
        {
            string requete = String.Format("delete from administrateur where id={0};", id);
            return utils.miseajour(requete);
        }

        public static administrateur Get_administrateur_ID(int id)
        {
            string requete = String.Format("select * from administrateur where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            administrateur c = new administrateur ();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
               
                c.password = rd.GetInt32(4);

            }
            utils.Disconnect();
            return c;
        }

        public static List<administrateur> Get_administrateur()
        {
            string requete = String.Format("select * from enseignant;");
            OleDbDataReader rd = utils.lire(requete);
            List<administrateur> L = new List<administrateur>();
            administrateur c;
            while (rd.Read())
            {
                c = new administrateur
                {
                    Id = rd.GetInt32(0),
                   
                    password = rd.GetInt32(4),
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
    }
}
