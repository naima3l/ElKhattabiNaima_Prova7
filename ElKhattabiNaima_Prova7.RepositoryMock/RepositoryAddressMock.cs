using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.RepositoryMock
{
    public class RepositoryAddressMock : IAddressRepository
    {
        List<Address> addresses = new List<Address>();
        public Address Add(Address item)
        {
            item.Id = (addresses.Count) + 1;

            var contact = RepositoryContactMock.contacts.Find(c => c.Id == item.ContactId);
            item.Contact = contact;
            contact.Addresses.Add(item);

            addresses.Add(item);
            return item;
        }

        public bool Delete(Address item)
        {
            throw new NotImplementedException();
        }

        public List<Address> Fetch()
        {
            throw new NotImplementedException();
        }

        public Address GetByAll(string nation, string postalCode, string province, string road, string type, int contactId, string city)
        {
            return addresses.FirstOrDefault(a => a.ContactId == contactId && a.City == city && a.Nation == nation && a.PostalCode == postalCode && a.Province == province && a.Road == road && a.Type == type);
        }

        public Address Update(Address item)
        {
            throw new NotImplementedException();
        }
    }
}
