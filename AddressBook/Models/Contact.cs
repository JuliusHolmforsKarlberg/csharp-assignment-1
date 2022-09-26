using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    internal class Contact
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string streetName { get; set; } = null!;
        public string postalCode { get; set; } = null!;
        public string city { get; set; } = null!;

    }
}
