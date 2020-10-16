using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class Bouteille
    {
        private int idBouteille;
        private int quantiteBouteille;
        private Vin leVin;

        public Bouteille(int unId, int uneQuantite, Vin unVin)
        {
            IdBouteille = unId;
            QuantiteBouteille = uneQuantite;
            LeVin = unVin;
        }

        public int IdBouteille { get => idBouteille; set => idBouteille = value; }
        public int QuantiteBouteille { get => quantiteBouteille; set => quantiteBouteille = value; }
        public Vin LeVin { get => leVin; set => leVin = value; }
    }
}
