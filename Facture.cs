using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirCSHARP
{
    public class Facture
    {
        private string idFacture;
        private DateTime dateFacture;
        private decimal montantTotal;
        private List<Produit> listeProduits;


        public Facture(string numero, DateTime date)
        {
            idFacture = numero;
            dateFacture = date;
            montantTotal = 0;
            listeProduits = new List<Produit>();
        }


        public void AjouterProduit(Produit produit)
        {
            listeProduits.Add(produit);
            montantTotal += produit.PrixUnitaire;
        }

        public void SupprimerProduit(Produit produit)
        {
            listeProduits.Remove(produit);
            montantTotal -= produit.PrixUnitaire;
        }

        public decimal CalculerMontantTotal()
        {
            return montantTotal;
        }
    }
}
