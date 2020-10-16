using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class Couleur
    {
        private string nomCouleur;

        public Couleur(string unNom)
        {
            NomCouleur = unNom;
        }

        public string NomCouleur { get => nomCouleur; set => nomCouleur = value; }
    }
}
