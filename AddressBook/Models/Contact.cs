using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string streetName { get; set; } = null!;
        public string postalCode { get; set; } = null!;
        public string city { get; set; } = null!;

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
