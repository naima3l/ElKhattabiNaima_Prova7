using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.RepositoryMock
{
    public class RepositoryContactMock : IContactRepository
    {
        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact{Id = 1, Name = "Isabella",LastName = "Castiglia"},
            new Contact{Id = 2, Name = "Ferdinando",LastName = "Aragona"},
            new Contact{Id = 3, Name = "Amerigo",LastName = "Vespucci"}
        };
        public Contact Add(Contact item)
        {
            item.Id = (contacts.Count) + 1;
            contacts.Add(item);
            return item;
        }

        public bool Delete(Contact item)
        {
            var itemToDelete = contacts.FirstOrDefault(c => c.Id == item.Id);
            if(itemToDelete == null)
            {
                return false;
            }
            contacts.Remove(itemToDelete);
            return true;
        }

        public List<Contact> Fetch()
        {
            return contacts;
        }

        public Contact GetById(int id)
        {
            return contacts.Find(c => c.Id == id);
        }

        public Contact GetByNameSurname(string name, string lastName)
        {
            return contacts.FirstOrDefault(c => c.Name == name && c.LastName == lastName);
        }

        public Contact Update(Contact item)
        {
            throw new NotImplementedException();
        }
    }
}
