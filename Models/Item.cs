

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
}
