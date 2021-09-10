using ElKhattabiNaima_Prova7.Core;
using ElKhattabiNaima_Prova7.Core.BusinessLayer;
using ElKhattabiNaima_Prova7.Core.Entities;
using ElKhattabiNaima_Prova7.RepositoryEF.RepositoriesEF;
using System;
using Xunit;

namespace ElKhattabiNaima_Prova7.Test
{
    public class ContactTest
    {
        private static readonly IBusinessLayer bl = new MainBL(new RepositoryContactEF(), new RepositoryAddressEF());
        [Fact]
        public void Test1()
        {
            //ARRANGE
            Contact contact = new Contact();
            contact.Name = "Pippo";
            contact.LastName = "Pippino";

            //ACT
            string res = bl.AddContact(contact);

            //ASSERT
            Assert.NotNull(res);
            Assert.Equal("Il contatto è stato aggiunto correttamente",res);


        }
    }
}
