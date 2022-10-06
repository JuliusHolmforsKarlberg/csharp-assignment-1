using AddressBook.Models;
using AddressBook.Services;
using Newtonsoft.Json;
// Creating new contact list
var contactCatalog = new List<Contact>();
// Getting folder path Json
var filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ContactCatalog.json";

// Reading and adding Contact(s) from a file and adding it the list
contactCatalog = JsonConvert.DeserializeObject<List<Contact>>(FileManager.Read(filePath));

do
{
    // Showing the menu options
    var option = MenuManager.OptionsMenu();

    switch (option)
    {
        case "1":
            // Viewing the contact catalog
            MenuManager.ViewListMenu(contactCatalog);
            break;

        case "2":
            // Creating a new contact and saving it to a file
            var contact = MenuManager.CreateMenu();
            if (contact != null)
            {
                contactCatalog.Add(contact);
                FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));
            }
            break;

        case "3":
            // Removing a contact and saving it to a file
            MenuManager.ViewListMenu(contactCatalog);
            MenuManager.RemoveMenu(ref contactCatalog);
            FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));
            break;

        case "4":
            // Updating an already existing contact
            MenuManager.ViewListMenu(contactCatalog);
            MenuManager.ShowUpdateContactInfo(ref contactCatalog);
            FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));
            break;

        // Default if not choosing 1-3 (Wrong option)
        default:
            Console.WriteLine("Invalid Option Selected");
            Console.ReadKey();
            break;
    }
} while (true);

MenuManager.ViewListMenu(contactCatalog);

contactCatalog.Add(MenuManager.CreateMenu());
FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));


MenuManager.ViewListMenu(contactCatalog);


MenuManager.RemoveMenu(ref contactCatalog);
FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));

MenuManager.ViewListMenu(contactCatalog);

MenuManager.ShowUpdateContactInfo(FileManager.Read(filePath));
FileManager.Save(filePath, JsonConvert.SerializeObject(contactCatalog));

MenuManager.ViewListMenu(contactCatalog);


