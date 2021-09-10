using ElKhattabiNaima_Prova7.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.InterfaceRepositories
{
    public interface IContactRepository : IRepository<Contact>
    {
        Contact GetByNameSurname(string name, string lastName);
        Contact GetById(int id);
    }
}
