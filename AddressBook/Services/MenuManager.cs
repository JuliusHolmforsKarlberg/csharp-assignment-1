using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal static class MenuManager
    {
        public static Contact CreateMenu()
        {
            var contact = new Contact();

            Console.Clear();
            Console.WriteLine("##### NEW CONTACT - ADDRESS BOOK #####");

            Console.Write("First Name: ");
            contact.firstName = Console.ReadLine() ?? "";

            Console.Write("Last Name: ");
            contact.lastName = Console.ReadLine() ?? "";

            Console.Write("Street Name: ");
            contact.streetName = Console.ReadLine() ?? "";

            Console.Write("Postal Code: ");
            contact.postalCode = Console.ReadLine() ?? "";

            Console.Write("City: ");
            contact.city = Console.ReadLine() ?? "";

            return contact;


        }
    }
}
