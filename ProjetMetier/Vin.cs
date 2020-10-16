using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class Vin
    {
        private string nomVin;
        private int millesimeVin;
        private Cepage leCepage;
        private Couleur laCouleur;
        private double prixDuVin;
        public Vin(string unNom, int unMillesime, Cepage unCepage, Couleur uneCouleur,double unPrix)
        {
            NomVin = unNom;
            MillesimeVin = unMillesime;
            LeCepage = unCepage;
            LaCouleur = uneCouleur;
            PrixDuVin = unPrix;
        }

        public string NomVin { get => nomVin; set => nomVin = value; }
        public int MillesimeVin { get => millesimeVin; set => millesimeVin = value; }
        public Cepage LeCepage { get => leCepage; set => leCepage = value; }
        public Couleur LaCouleur { get => laCouleur; set => laCouleur = value; }
        public double PrixDuVin { get => prixDuVin; set => prixDuVin = value; }
    }
}
