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
  public  class AdministrateursDAO
    {
        public static bool Insert_administrateur(int password, int id)
        {
            string requete = String.Format("insert into administrateur(id,password)" +
                " values ('{0}','{1}');", id, password);
            return Utils.miseajour(requete);
        }

        public static bool Update_administrateur(int password, int id)
        {
            string requete = String.Format("updat administrateur set" +
               "password='{0}',id='{1}'  where id={6};", password, id);
            return Utils.miseajour(requete);
        }

        public static bool Delete_administrateur(int id)
        {
            string requete = String.Format("delete from administrateur where id={0};", id);
            return Utils.miseajour(requete);
        }

        public static AdministrateursDAO Get_administrateur_ID(int id)
        {
            string requete = String.Format("select * from administrateur where id={0};", id);
            OleDbDataReader rd = Utils.lire(requete);
            BEL.Administrateurs c = new BEL.Administrateurs();
            while (rd.Read())
            {
                c.Id_administrateur = rd.GetInt32(0);

                c.Password = rd.GetInt32(4);

            }
            Utils.Disconnect();
            return c;
        }

        public static List<BEL.Administrateurs> Get_administrateur()
        {
            string requete = String.Format("select * from enseignant;");
            OleDbDataReader rd = Utils.lire(requete);
            List<BEL.Administrateurs> L = new List<BEL.Administrateurs>();
            BEL.Administrateurs c;
            while (rd.Read())
            {
                c = new BEL.Administrateurs
                {
                    Id_administrateur = rd.GetInt32(0),

                    Password = rd.GetInt32(4),
                };
                L.Add(c);
            }
            Utils.Disconnect();
            return L;
        }

        public static AdministrateursDAO Get_administrateur_ID(object p)
        {
            throw new NotImplementedException();
        }
    }
}

