using System;

namespace ProjetMetier
{
    public class Cepage
    {
        private string nomCepage;

        public Cepage(string unNom)
        {
            NomCepage = unNom;
        }

        public string NomCepage { get => nomCepage; set => nomCepage = value; }
    }
}
