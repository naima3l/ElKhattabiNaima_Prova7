using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.BusinessLayer
{
    public class MainBL : IBusinessLayer
    {
        private readonly IContactRepository contactRepo;
        private readonly IAddressRepository addressRepo;

        public MainBL(IContactRepository contactRepository, IAddressRepository addressRepository)
        {
            contactRepo = contactRepository;
            addressRepo = addressRepository;
        }

        public MainBL()
        {
        }

        #region Contact

        public string AddContact(Contact contact)
        {
            var existingContact = contactRepo.GetByNameSurname(contact.Name, contact.LastName);
            if(existingContact != null)
            {
                return "Esiste già un contatto con quel nome e cognome";
            }
            contactRepo.Add(contact);
            return "Il contatto è stato aggiunto correttamente";

        }

        public string DeleteContactById(int id)
        {
            var existingContact = contactRepo.GetById(id);
            if(existingContact == null)
            {
                return "Il contatto non è presente in rubrica";
            }
            if(existingContact.Addresses.Count != 0)
            {
                return "Il contatto non può essere eliminato perchè associato a uno o più indirizzi";
            }
            bool esito = contactRepo.Delete(existingContact);
            if (esito == false)
            {
                return "C'è stato un errore nella rimozione del contatto";
            }
            return "Il contatto è stato eliminato correttamente";
        }

        public List<Contact> ShowContacts()
        {
            return contactRepo.Fetch();
        }
        #endregion

        #region Address
        public string AddAddress(Address address)
        {
            //var existingAddress = addressRepo.GetByAll(address.Nation, address.PostalCode, address.Province, address.Road, address.Type, address.ContactId, address.City);
            //if (existingAddress != null)
            //{
            //    return "Esiste già un indirizzo con gli stessi dati";
            //}
            var existingContact = contactRepo.GetById(address.ContactId);
            if(existingContact == null)
            {
                return "Errore : id contatto non presente";
            }
            addressRepo.Add(address);
            return "L'indirizzo è stato aggiunto correttamente";
        }
        #endregion
    }
}
