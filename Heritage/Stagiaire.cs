using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Stagiaire : Personne
    {
     
        public Stagiaire(string Nom):base(Nom)
        {
        }

        public override string ToString()
        {
   
            return "Stagiaire :" + this.Nom + " " + this.DateNaissance;
        }

        public override bool Equals(object obj)
        {
            Personne personne = obj as Personne;
            if (this.Nom == personne.Nom) return true;
            else
            {
                return false;
            }
        }

        public override string Presentation()
        {
            return $"Je suis Stagiaire et je m'appele {this.Nom}";
        }

        public override string NomComplet()
        {
            return $"{this.Nom} {this.Prenom}";
        }
    }
}
