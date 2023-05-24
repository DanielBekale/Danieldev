using System;
using DevoirCSHARP;

namespace DevoirCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création des instances
            Produit produit1 = SaisirProduit();

            Client client = SaisirClient();

            Facture facture = new Facture("F1", DateTime.Now);
            facture.AjouterProduit(produit1);

            Paiement paiement = SaisirPaiement(facture);

            Stock stock = new Stock();
            stock.AjouterProduit(produit1);

            // Exemple d'utilisation des fonctionnalités
            Console.WriteLine("Montant total de la facture : " + facture.CalculerMontantTotal());

            // Enregistrer le paiement
            paiement.EnregistrerPaiement();

            // Supprimer un produit de la facture
            facture.SupprimerProduit(produit1);

            // Afficher le nouveau montant total de la facture
            Console.WriteLine("Nouveau montant total de la facture : " + facture.CalculerMontantTotal());

            // Supprimer un produit du stock
            stock.SupprimerProduit(produit1);
        }

        static Produit SaisirProduit()
        {
            Console.WriteLine("Saisir les informations du produit :");
            Console.Write("Code produit : ");
            string codeProduit = Console.ReadLine();
            Console.Write("Libellé produit : ");
            string libelleProduit = Console.ReadLine();
            Console.Write("Prix unitaire : ");
            decimal prixUnitaire;
            while (!decimal.TryParse(Console.ReadLine(), out prixUnitaire))
            {
                Console.WriteLine("Veuillez entrer un prix valide.");
                Console.Write("Prix unitaire : ");
            }

            Produit produit = new Produit(codeProduit, libelleProduit, prixUnitaire);
            return produit;
        }

        static Client SaisirClient()
        {
            Console.WriteLine("Saisir les informations du client :");
            Console.Write("ID client : ");
            string idClient = Console.ReadLine();
            Console.Write("Nom client : ");
            string nomClient = Console.ReadLine();
            Console.Write("Prénom client : ");
            string prenomClient = Console.ReadLine();
            Console.Write("Adresse client : ");
            string adresseClient = Console.ReadLine();

            Client client = new Client(idClient, nomClient, prenomClient, adresseClient);
            return client;
        }

        static Paiement SaisirPaiement(Facture facture)
        {
            Console.WriteLine("Saisir les informations du paiement :");
            Console.Write("Montant payé : ");
            decimal montantPaye;
            while (!decimal.TryParse(Console.ReadLine(), out montantPaye))
            {
                Console.WriteLine("Veuillez entrer un montant valide.");
                Console.Write("Montant payé : ");
            }

            Paiement paiement = new Paiement(facture, montantPaye);
            return paiement;
        }
    }
}
