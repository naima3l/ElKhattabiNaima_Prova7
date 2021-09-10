using ElKhattabiNaima_Prova7.Core.BusinessLayer;
using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.RepositoryEF.RepositoriesEF;
using ElKhattabiNaima_Prova7.RepositoryMock;
using System;

namespace ElKhattabiNaima_Prova7
{
    class Program
    {
        //private static readonly IBusinessLayer bl = new MainBL(new RepositoryContactMock(),new RepositoryAddressMock());
        private static readonly IBusinessLayer bl = new MainBL(new RepositoryContactEF(),new RepositoryAddressEF());
        static void Main(string[] args)
        {
            bool check = true;
            int choice;
            do
            {
                Console.WriteLine("Benvenuto nella tua rubrica virtuale!");
                Console.WriteLine("Premi 1 per visualizzare tutti i contatti\nPremi 2 per aggiungere un nuovo contatto\nPremi 3 per aggiungere un indirizzo ad un contatto\nPremi 4 per eliminare un contatto\nPremi 0 per uscire");
                while(!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
                {
                    Console.WriteLine("Opzione non valida. Riprova!");
                }

                switch(choice)
                {
                    case 1:
                        ShowContacts();
                        break;
                    case 2:
                        AddContact();
                        break;
                    case 3:
                        AddAddress();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 0:
                        check = false;
                        break;
                }
            } while (check);
        }

        private static void DeleteContact()
        {
            Console.WriteLine("Quale contatto vuoi eliminare?");
            ShowContacts();
            Console.WriteLine("Inserisci l'id del contatto che vuoi eliminare");
            int id;
            while(!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("Opzione non valida. Riprova!");
            }
            string esito = bl.DeleteContactById(id);
            Console.WriteLine(esito);
        }

        private static void AddAddress()
        {
            Console.WriteLine("A quale contatto vuoi aggiungere un indirizzo?");
            ShowContacts();
            Console.WriteLine("Inserisci l'id del contatto");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("Opzione non valida. Riprova!");
            }

            Console.WriteLine("Inserisci la tipologia dell'inidirizzo");
            string type = Console.ReadLine();
            while (String.IsNullOrEmpty(type))
            {
                Console.WriteLine("Inserisci un tipo valido!");
            }
            Console.WriteLine("Inserisci la via dell'inidirizzo");
            string road = Console.ReadLine();
            while (String.IsNullOrEmpty(road))
            {
                Console.WriteLine("Inserisci una via valida!");
            }
            Console.WriteLine("Inserisci il cap dell'inidirizzo");
            string cap = Console.ReadLine();
            while (String.IsNullOrEmpty(cap))
            {
                Console.WriteLine("Inserisci un cap valido!");
            }
            Console.WriteLine("Inserisci la città dell'inidirizzo");
            string city = Console.ReadLine();
            while (String.IsNullOrEmpty(city))
            {
                Console.WriteLine("Inserisci una città valida!");
            }
            Console.WriteLine("Inserisci la provincia dell'inidirizzo");
            string province = Console.ReadLine();
            while (String.IsNullOrEmpty(province))
            {
                Console.WriteLine("Inserisci una provincia valida!");
            }
            Console.WriteLine("Inserisci la nazione dell'inidirizzo");
            string nation = Console.ReadLine();
            while (String.IsNullOrEmpty(nation))
            {
                Console.WriteLine("Inserisci una nazione valida!");
            }

            Address address = new Address();
            address.Nation = nation;
            address.PostalCode = cap;
            address.Province = province;
            address.Road = road;
            address.Type = type;
            address.City = city;
            address.ContactId = id;

            string esito = bl.AddAddress(address);
            Console.WriteLine(esito);
        }

        private static void AddContact()
        {
            Console.WriteLine("Inserisci il nome");
            string name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Inserisci un nome valido!");
            }
            Console.WriteLine("Inserisci il cognome");
            string lastname = Console.ReadLine();
            while (String.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Inserisci un cognome valido!");
            }

            Contact contact = new Contact();
            contact.Name = name;
            contact.LastName = lastname;

            string esito = bl.AddContact(contact);
            Console.WriteLine(esito);
        }

        private static void ShowContacts()
        {
            var contacts = bl.ShowContacts();
            if(contacts.Count == 0)
            {
                Console.WriteLine("Nessun contatto in rubrica");
            }
            else
            {
                foreach(var c in contacts)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
    }
}
