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
   public class ProjecteursDAO
    {
        public static bool Insert_projecteur(string etat, int id_projecteur)
        {
            string requete = String.Format("insert into projecteur(etat,id_projecteur)" +
                " values ('{0}','{1}');", etat, id_projecteur);
            return Utils.miseajour(requete);
        }
        public static bool Delete_projecteur(int id_projecteur)
        {
            string requete = String.Format("delete from projrcteur where id_projecteur={0};", id_projecteur);
            return Utils.miseajour(requete);
        }
        public static Projecteurs Get_projecteur(int id_projecteur)
        {
            string requete = String.Format("select * from projrcteur where id_projecteur={0};", id_projecteur);
            OleDbDataReader rd = Utils.lire(requete);
            Projecteurs c = new Projecteurs();
            while (rd.Read())
            {
                c.Etat = rd.GetString(0);
                c.Id_projecteur = rd.GetInt32(1);



            }
            Utils.Disconnect();
            return c;
        }
        public static List<Projecteurs> Get_projecteur()
        {
            string requete = String.Format("select * from projecteur;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Projecteurs> L = new List<Projecteurs>();
            Projecteurs c;
            while (rd.Read())
            {
                c = new Projecteurs
                {
                    Id_projecteur = rd.GetInt32(0),
                    Etat = rd.GetString(1),


                };
                L.Add(c);
            }
            Utils.Disconnect();
            return L;
        }
    }
}

