using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.Core.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

        public override string ToString()
        {
            return $"Contatto -> Id {Id}, Nome :  {Name}, Cognome : {LastName}";
        }
    }
}
