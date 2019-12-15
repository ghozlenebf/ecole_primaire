using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
  public  class projecteurDAO
    {
        public static bool Insert_projecteur(string etat, int id_projecteur)
        {
            string requete = String.Format("insert into projecteur(etat,id_projecteur)" +
                " values ('{0}','{1}');", etat, id_projecteur);
            return utils.miseajour(requete);
        }
        public static bool Delete_projecteur(int id_projecteur)
        {
            string requete = String.Format("delete from projrcteur where id_projecteur={0};", id_projecteur);
            return utils.miseajour(requete);
        }
        public static classeDAO Get_projecteur(int id_projecteur)
        {
            string requete = String.Format("select * from projrcteur where id_projecteur={0};", id_projecteur);
            OleDbDataReader rd = utils.lire(requete);
            projecteur c = new projecteur();
            while (rd.Read())
            {
                c.etat = rd.GetString(0);
                c.id_projecteur = rd.GetInt32(1);
               


            }
            utils.Disconnect();
            return c;
        }
        public static List<projecteur> Get_projecteur()
        {
            string requete = String.Format("select * from projecteur;");
            OleDbDataReader rd = utils.lire(requete);
            List<projecteur> L = new List<projecteur>();
            projecteur c;
            while (rd.Read())
            {
                c = new projecteur
                {
                    id_projecteur = rd.GetInt32(0),
                    etat = rd.GetString(1),


                };
                    L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
    }
}
