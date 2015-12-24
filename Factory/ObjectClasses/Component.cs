namespace Factory.ObjectClasses
{
    public class Component
    {
        public string Name { get; set; }

        public string ShopName { get; set; }

        public string Count { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public string Uuid { private get; set; }

        public string ShopUuid { get; set; }

        public string GetUuid()
        {
            return Uuid;
        }
    }
}