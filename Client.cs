using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirCSHARP
{
    public class Client
    {
        private string idClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        

        public Client(string id, string nom,string prenom, string adresse)
        {
            idClient = id;
            nomClient = nom;
            prenomClient = prenom;
            adresseClient = adresse;
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
    }
}
