using ElKhattabiNaima_Prova7.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.InterfaceRepositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        Address GetByAll(string nation, string postalCode, string province, string road, string type, int contactId, string city);
    }
}
