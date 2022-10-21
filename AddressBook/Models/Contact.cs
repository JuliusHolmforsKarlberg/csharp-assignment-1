using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact
    {
        internal List<Contact> id;

        // This method creates the contacts' structure in the address book.
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public static object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public static object IndexOf(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
