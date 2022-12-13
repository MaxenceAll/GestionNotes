using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    internal abstract class Personne
    {
        // Attributs :
        private string nom      = "Nom non défini";
        private string prenom   = "Prénom non défini";
        // Propriétés :
        public string Nom { get { return nom; } set { Nom = value; } }
        public string Prenom { get { return prenom; } set { Prenom = value; } }
        // Constructeurs :
        public Personne(string nomPersonne, string prenomPersonne)
        {
            this.nom            = nomPersonne;
            this.prenom         = prenomPersonne;
        }
        // ToString Override
        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
