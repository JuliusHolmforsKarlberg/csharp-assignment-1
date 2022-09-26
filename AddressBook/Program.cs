using AddressBook.Models;
using AddressBook.Services;
using Newtonsoft.Json;


var filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
var contactCatalog = new List<Contact>();


contactCatalog.Add(MenuManager.CreateMenu());
FileManager.Save("", JsonConvert.SerializeObject(contactCatalog));
