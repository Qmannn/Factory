using System.Security.Cryptography.X509Certificates;

namespace Factory.ObjectClasses
{
    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Uuid { private get; set; }
        public string GetUuid()
        {
            return Uuid;
        }
    }
}