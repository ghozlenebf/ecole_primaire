using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;
using System.Reflection;
using System.IO;

namespace DAL
{
   public class emploisDAO
    {
        public static bool Insert_emplois(classes salle, DateTime heure, enseignants id_enseignant)
        {
            string requete = String.Format("insert into emplois(classe,heure,enseignant)" +
                " values ('{0}','{1}','{2}') where classe.non_classe=classe and  enseignants.id= id_enseignant, id_classe);", salle, id_enseignant, heure);
            return utils.miseajour(requete);
        }
        public static bool Delete_emplois(classes salle,DateTime heure,enseignants id_enseignants)
        {
            string requete = String.Format("delete  * from emplois where classe.nom_classe= salle and enseignants.id = id_enseignant; ",salle,id_enseignants,heure);
            return utils.miseajour(requete);
        }
        public static emplois Get_emplois(enseignants enseignant)
        {
            string requete = String.Format("select * from emplois where enseignant={0}  ;", enseignant);
            OleDbDataReader rd = utils.lire(requete);
            emplois c = new emplois();
            while (rd.Read())
            {
                c.heure = rd.GetDateTime(0);
                c.salle = rd.GetString(id_classe);
                c.enseignant = rd.GetString(enseignants.id);


            }
            utils.Disconnect();
            return c;
        }
        public static List<emplois> Get_emplois()

        {
            string requete = String.Format("select * from emplois;");
            OleDbDataReader rd = utils.lire(requete);
            List<emplois> L = new List<emplois>();
            emplois c;
            while (rd.Read())
            {
                c = new emplois
                {
                    heure = rd.GetDateTime(0),
                    enseignant= rd.GetString(enseignants.enseignant),
                    salle = rd.classes(2),

                };
                L.Add(c);

            }
            utils.Disconnect();
            return L;
        }

    }
}

