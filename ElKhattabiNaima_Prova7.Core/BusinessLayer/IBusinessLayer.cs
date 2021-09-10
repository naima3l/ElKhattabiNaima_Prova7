using ElKhattabiNaima_Prova7.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Contact
        public List<Contact> ShowContacts();
        public string AddContact(Contact contact);
        public string DeleteContactById(int id);
        #endregion

        #region Address
        public string AddAddress(Address address);
        #endregion
    }
}
