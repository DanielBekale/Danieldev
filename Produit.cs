using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirCSHARP
{
    public class Produit
    {
        private string idProduit;
        private string libelleProduit;
        private decimal prixUnitaire;

        string getlibelleProduit()
        {
            return libelleProduit;
        }

        public Produit(string code, string libelle, decimal prix)
        {
            idProduit = code;
            libelleProduit = libelle;
            prixUnitaire = prix;
        }

        public decimal PrixUnitaire
        {
            get { return prixUnitaire; }
        }
    }
}
