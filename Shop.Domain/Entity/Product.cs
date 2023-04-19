
using Shop.Domain.Enum;
using System.Drawing;
using System.Reflection;

namespace Shop.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public Age CategoryAge { get; set; }
        public Gender CategoryGender { get; set; }
        public Season CategorySeason { get; set; }
        public SizeOfProduct CategorySize { get; set; }
        public ClothesTypes CategoryTypes { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsFeatured { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
