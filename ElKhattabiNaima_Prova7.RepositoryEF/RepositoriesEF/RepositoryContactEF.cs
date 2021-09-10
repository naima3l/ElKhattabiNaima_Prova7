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
    public class RepositoryContactEF : IContactRepository
    {
        public Contact Add(Contact item)
        {
            using (var ctx = new RubricaContext())
            {
                ctx.Contacts.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Contact item)
        {
            using (var ctx = new RubricaContext())
            {
                ctx.Contacts.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Contact> Fetch()
        {
            using (var ctx = new RubricaContext())
            {
                return ctx.Contacts.Include(c => c.Addresses).ToList();
            }
        }

        public Contact GetById(int id)
        {
            using (var ctx = new RubricaContext())
            {
                return ctx.Contacts.Include(c => c.Addresses).FirstOrDefault(c => c.Id == id);
            }
        }

        public Contact GetByNameSurname(string name, string lastName)
        {
            using (var ctx = new RubricaContext())
            {
                return ctx.Contacts.Include(c => c.Addresses).FirstOrDefault(c => c.Name == name && c.LastName == lastName);
            }
        }

        public Contact Update(Contact item)
        {
            throw new NotImplementedException();
        }
    }
}
