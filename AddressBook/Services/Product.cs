namespace AddressBook.Services
{
    internal class Product
    {
        public Product()
        {
        }

        public static implicit operator CancellationTokenRegistration(Product v)
        {
            throw new NotImplementedException();
        }
    }
}