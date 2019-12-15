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
   public class EmploisDAO
    {
        public static bool Insert_emplois(Classes salle, DateTime heure, Enseignants id_enseignant)
        {
            string requete = String.Format("insert into emplois(classe,heure,enseignant)" +
                " values ('{0}','{1}','{2}') where classe.non_classe=classe and  enseignants.id= id_enseignant, id_classe);", salle, id_enseignant, heure);
            return Utils.miseajour(requete);
        }
        public static bool Delete_emplois(Classes salle,DateTime heure,Enseignants id_enseignants)
        {
            string requete = String.Format("delete  * from emplois where classe.nom_classe= salle and enseignants.id = id_enseignant; ",salle,id_enseignants,heure);
            return Utils.miseajour(requete);
        }
        public static Emplois Get_emplois(Enseignants enseignant)
        {
            string requete = string.Format("select * from emplois where enseignant={0}  ;", enseignant);
            OleDbDataReader rd = Utils.lire(requete);
            Emplois c = new Emplois();
            while (rd.Read())
            {
                c.Heure = rd.GetDateTime(0);
                c.Salle = rd.GetString(Id_classe);
                c.Enseignant = rd.GetString(Enseignants.Id);


            }
            Utils.Disconnect();
            return c;
        }
        public static List<Emplois> Get_emplois()

        {
            string requete = String.Format("select * from emplois;");
            OleDbDataReader rd = Utils.lire(requete);
            List<Emplois> L = new List<Emplois>();
            Emplois c;
            while (rd.Read())
            {
                c = new Emplois
                {
                    Heure = rd.GetDateTime(0),
                    Enseignant= rd.GetString(Enseignants.Enseignant),
                    Salle = rd.Classes(2),

                };
                L.Add(c);

            }
            Utils.Disconnect();
            return L;
        }

    }
}

