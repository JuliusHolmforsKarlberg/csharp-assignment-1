using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public static class FileManager
    {
        // This method is saving the file path
        public static void Save(string filePath, string text)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(text);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Unable to save contact catalog");
                Console.ReadKey();
            }
        }

        public static string Read(string filePath)
            // This method is reading the file path
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch { }

            return "[]";
        }

        public static string Read()
        {
            throw new NotImplementedException();
        }

    }
}
