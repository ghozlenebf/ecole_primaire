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
    public class classeDAO
    {
        public static bool Insert_classe(string nom_classe, int niveau, int id_classe)
        {
            string requete = String.Format("insert into classe(nom_classe,niveau,id_classe)" +
                " values ('{0}','{1}','{2}');", nom_classe, niveau, id_classe);
            return utils.miseajour(requete);
        }
        public static bool Delete_classe(int id_classe)
        {
            string requete = String.Format("delete from classe where id_classe={0};", id_classe);
            return utils.miseajour(requete);
        }
        public static classe Get_classe(int id_classe)
        {
            string requete = String.Format("select * from classe where id_classe={0};", id_classe);
            OleDbDataReader rd = utils.lire(requete);
            classe c = new classe();
            while (rd.Read())
            {
                c.nom_classe = rd.GetString(0);
                c.niveau = rd.GetInt32(1);
                c.id_classe = rd.GetInt32(2);


            }
            utils.Disconnect();
            return c;
        }
        public static List<classe> Get_classe()
        
        {
            string requete = String.Format("select * from classe;");
            OleDbDataReader rd = utils.lire(requete);
            List<classe> L = new List<classe>();
            classe c;
            while (rd.Read())
            {
                c = new classe
                {
                    niveau = rd.GetInt32(0),
                    nom_classe = rd.GetString(1),
                    id_classe = rd.GetInt32(2),

                };
                    L.Add(c);
            
             } 
            utils.Disconnect();
            return L;
        } 

    }
}

