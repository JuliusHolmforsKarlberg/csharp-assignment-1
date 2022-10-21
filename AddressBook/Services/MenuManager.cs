using AddressBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace AddressBook.Services
{
    public static class MenuManager
    {
        public static Contact CreateMenu()

        {
            // This method creates a new contact. Try-catch består av ett try block och en catch sats, Try blocket körs om inte undantaget triggas vilket isåfall gör så att catch satsen utlöses.
            var contact = new Contact();

            try
            {
                Console.Clear();
                Console.WriteLine("##### CREATE NEW CONTACT - ADDRESS BOOK #####");

                Console.Write("First Name: ");
                contact.FirstName = Console.ReadLine() ?? "";

                Console.Write("Last Name: ");
                contact.LastName = Console.ReadLine() ?? "";

                Console.Write("Street Name: ");
                contact.StreetName = Console.ReadLine() ?? "";

                Console.Write("Postal Code: ");
                contact.PostalCode = Console.ReadLine() ?? "";

                Console.Write("City: ");
                contact.City = Console.ReadLine() ?? "";

                return contact;
            }
            catch
            {
                Console.WriteLine("Invalid Values Added");
                Console.ReadKey();
            }

            return null!;
        }

        public static void ViewListMenu(ref List<Contact> list)
        {

                // This method views the contact catalog/list.
                Console.Clear();
            Console.WriteLine("####### VIEW CONTACT CATALOG #######");

            foreach (var contact in list)
            {
                Console.WriteLine($"{contact.Id} - {contact.FirstName} {contact.LastName}, {contact.StreetName}, {contact.PostalCode} {contact.City}");
            }

            if (list.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to see more information about a specific contact?: Y/N?");
                var option = Console.ReadLine();
                if (option.ToLower() == "y")
                {
                    ShowContactDetails(ref list);

                }
            }

            Console.ReadKey();
        }

        public static void ShowContactDetails(ref List<Contact> list)
        {
            Console.Write("Write the contact's id: ");
            var id = Guid.Parse(Console.ReadLine());

            var contact = list.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            try
            {

                Console.Clear();
                Console.Write("##### Contact Catalog #####");
                Console.WriteLine($"ID: \t {contact?.Id}");
                Console.WriteLine($"First Name: \t {contact.FirstName}");
                Console.WriteLine($"Last Name: \t {contact.LastName}");
                Console.WriteLine($"Street Name: \t {contact.StreetName}");
                Console.WriteLine($"Postal Code: \t {contact.PostalCode}");
                Console.WriteLine($"City: \t {contact.City}");
                Console.WriteLine();
                Console.WriteLine("1. Update Contact");
                Console.WriteLine("2. Remove Contact");
                Console.WriteLine("Enter Option: ");
                var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            ShowUpdateContactInfo(ref list);
                            break;

                        case "2":
                            RemoveMenu(ref list);
                            
                            break;

                        default:
                            break;
                    }


                }
                catch
                {
                    Console.WriteLine("Invalid Id Selected");
                    Console.ReadKey();
                }
        }


        public static void RemoveMenu(ref List<Contact> list)
        {
            try
            {
                // This method removes one contact.
                Console.Clear();
                Console.WriteLine("####### REMOVE CONTACT #######");

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
            // This method creates the options menu.
            Console.Clear();
            Console.WriteLine("####### CONTACT CATALOG #######");
            Console.WriteLine("1. View Contact Catalog");
            Console.WriteLine("2. Create New Contact");
            Console.WriteLine("3. Remove Contact");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Show Contact Details Of One Specific Contact");
            Console.WriteLine("Choose One Option (1-5): ");
            return Console.ReadLine() ?? "";
        }

        public static void ShowUpdateContactInfo(ref List<Contact> list)
        {
        try
            {
                // This method updates an already existing contact
                Console.Write("Id For Contact To Update: ");
                var id = Guid.Parse(Console.ReadLine());

                var contact = list.FirstOrDefault(x => x.Id == id);
                if (contact != null)
                {

                    Console.Write("Contact's First Name: ");
                    var firstName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(firstName))
                        contact.FirstName = firstName;
                    

                    Console.Write("Contact's Last Name: ");
                    var lastName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(lastName))
                        contact.LastName = lastName;


                    Console.Write("Contact's Street Name: ");
                    var streetName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(streetName))
                        contact.StreetName = streetName;


                    Console.Write("Contact's Postal Code: ");
                    var postalCode = Console.ReadLine();
                    if (!string.IsNullOrEmpty(postalCode))
                        contact.PostalCode = postalCode;


                    Console.Write("Contact's City: ");
                    var city = Console.ReadLine();
                    if (!string.IsNullOrEmpty(city))
                        contact.City = city;
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


        public static ReadOnlySpan<char> ShowContactDetails()
        {
            return new ReadOnlySpan<char>();
        }

    }

}