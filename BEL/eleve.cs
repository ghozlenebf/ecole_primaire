using System;

namespace BEL
{
    public class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Prenom_parent { get; set; }
        public int Id { get; set; }
        public string Adresse { get; set; }
        public DateTime Date_naissance { get; set; }
        public int Password { get; set; }
    }
}
