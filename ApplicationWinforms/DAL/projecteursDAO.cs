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
   public class projecteursDAO
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
        public static projecteurs Get_projecteur(int id_projecteur)
        {
            string requete = String.Format("select * from projrcteur where id_projecteur={0};", id_projecteur);
            OleDbDataReader rd = utils.lire(requete);
            projecteurs c = new projecteurs();
            while (rd.Read())
            {
                c.etat = rd.GetString(0);
                c.id_projecteur = rd.GetInt32(1);



            }
            utils.Disconnect();
            return c;
        }
        public static List<projecteurs> Get_projecteur()
        {
            string requete = String.Format("select * from projecteur;");
            OleDbDataReader rd = utils.lire(requete);
            List<projecteurs> L = new List<projecteurs>();
            projecteurs c;
            while (rd.Read())
            {
                c = new projecteurs
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

