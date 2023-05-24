using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirCSHARP
{
    public class Stock
    {
        private List<Produit> listeProduits;

        public Stock()
        {
            listeProduits = new List<Produit>();
        }

        public void AjouterProduit(Produit produit)
        {
            listeProduits.Add(produit);
        }

        public void SupprimerProduit(Produit produit)
        {
            listeProduits.Remove(produit);
        }

       
    }
}
