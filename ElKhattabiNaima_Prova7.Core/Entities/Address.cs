using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Nation { get; set; }

        public Contact Contact { get; set; }
        public int ContactId { get; set; }

        public override string ToString()
        {
            return $"Indirizzo : {Type}, Via : {Road}, Città : {City}, CAP : {PostalCode}, Provincia : {Province}, Nazione : {Nation}, {Contact.ToString()}";
        }
    }
}
