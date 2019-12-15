using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class eleve
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string prenom_parent { get; set; }
        public int id { get; set; }
        public string adresse { get; set; }
        public DateTime date_naissance { get; set; }
        public int password { get; set; }
    }
}
