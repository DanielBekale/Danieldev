using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirCSHARP
{
    public class Paiement
    {
        private Facture facture;
        private decimal montantPaye;

        public Paiement(Facture facture, decimal montant)
        {
            this.facture = facture;
            montantPaye = montant;
        }

        public void EnregistrerPaiement()
        {
            
        }
    }
}
