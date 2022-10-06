using AddressBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook.Services
{
    public static class MenuManager
    {
        public static Contact CreateMenu()

        {
            var contact = new Contact();

            try
            {
                Console.Clear();
                Console.WriteLine("##### CREATE NEW CONTACT - ADDRESS BOOK #####");

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
            catch
            {
                Console.WriteLine("Invalid Values Added");
                Console.ReadKey();
            }

            return null!;
        }

        public static void ViewListMenu(List<Contact> list)
        {
            Console.Clear();
            Console.WriteLine("####### VIEW CONTACT CATALOG #######");

            foreach (var contact in list)
            {
                Console.WriteLine($"{contact.Id} - {contact.firstName} {contact.lastName}, {contact.streetName}, {contact.postalCode} {contact.city}");
            }

            Console.ReadKey();
        }


        public static void RemoveMenu(ref List<Contact> list)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("####### REMOVE CONTACT");

                Console.Write("Contact Id: ");
                var id = Guid.Parse(Console.ReadLine());

                list = list.Where(x => x.Id != id).ToList();
            }
            catch
            {
                Console.WriteLine("Invalid Id Selected");
                Console.ReadKey();
            }

        }

        public static string OptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("####### CONTACT CATALOG #######");
            Console.WriteLine("1. View Contact Catalog");
            Console.WriteLine("2. Create New Contact");
            Console.WriteLine("3. Remove Contact");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("Choose One Option (1-4): ");
            return Console.ReadLine() ?? "";
        }

        public static void ShowUpdateContactInfo(ref List<Contact> list)
        {
        try
            {
                // This method updates an already existing contact
                Console.Write("Id For Contact To Update");
                var id = Guid.Parse(Console.ReadLine());

                var contact = list.FirstOrDefault(x => x.Id == id);
                if (contact != null)
                {

                    Console.Write("Contact's First Name: ");
                    var firstName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(firstName))
                        contact.firstName = firstName;
                    

                    Console.Write("Contact's Last Name: ");
                    var lastName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(lastName))
                        contact.lastName = lastName;


                    Console.Write("Contact's Street Name: ");
                    var streetName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(streetName))
                        contact.streetName = streetName;


                    Console.Write("Contact's Postal Code: ");
                    var postalCode = Console.ReadLine();
                    if (!string.IsNullOrEmpty(postalCode))
                        contact.postalCode = postalCode;


                    Console.Write("Contact's City: ");
                    var city = Console.ReadLine();
                    if (!string.IsNullOrEmpty(city))
                        contact.city = city;
                }

                Console.WriteLine("The Contact Has Been Updated");
                
            }
            catch
            {
                Console.WriteLine("Invalid Values Added");
            }

            Console.ReadKey();

        }

        public static void ShowUpdateContactInfo(string filePath)
        {
            throw new NotImplementedException();
        }

        public static ReadOnlySpan<char> ShowUpdateContactInfo()
        {
            return new ReadOnlySpan<char>();
        }
    }

}