using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.Core.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.RepositoryEF.RepositoriesEF
{
    public class RepositoryAddressEF : IAddressRepository
    {
        public Address Add(Address item)
        {
            using (var ctx = new RubricaContext())
            {
                ctx.Addresses.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Address item)
        {
            using (var ctx = new RubricaContext())
            {
                ctx.Addresses.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Address> Fetch()
        {
            throw new NotImplementedException();
        }

        public Address GetByAll(string nation, string postalCode, string province, string road, string type, int contactId, string city)
        {
            using (var ctx = new RubricaContext())
            {
                return ctx.Addresses.Include(a=> a.Contact).FirstOrDefault(a => a.ContactId == contactId && a.City == city && a.Nation == nation && a.PostalCode == postalCode && a.Province == province && a.Road == road && a.Type == type);
            }
        }

        public Address Update(Address item)
        {
            throw new NotImplementedException();
        }
    }
}
