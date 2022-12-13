using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    internal class Eleve : Personne
    {
        // Attributs :
        private int age = -1;
        private Classe classe;
        private List<Note> ListeNotes;
        // Propriétés :
        public int Age { get { return age; } set { Age = value; } }
        // Constructeurs :
        public Eleve(string nom, string prenom, int age) : base(nom, prenom)
        {
            this.age = age;
            ListeNotes = new List<Note>();
        }
        // Methodes :
        public void ajouterNote(Note noteToAdd)
        {
            ListeNotes.Add(noteToAdd);
        }
        public void supprimerNote(Note noteToRemove)
        {
            ListeNotes.Remove(noteToRemove);
        }
        // ToString Override
        public override string ToString()
        {
            return base.ToString()+ " "+age;
        }
    }
}
