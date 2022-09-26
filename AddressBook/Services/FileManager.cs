using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal static class FileManager
    {
        public static void Save(string filePath, string text)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(text);
        }

        public static string Read(string filePath)
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
    }
}
