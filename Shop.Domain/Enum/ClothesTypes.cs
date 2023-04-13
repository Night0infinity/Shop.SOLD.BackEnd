using System.ComponentModel.DataAnnotations;
namespace Shop.Domain.Enum
{
    public enum ClothesTypes
    {
        [Display(Name = "Взуття")]
        Shoes = 0,
        [Display(Name = "Верхній одяг")]
        Outerwear = 1,
        [Display(Name = "Нижня білизна")]
        Underwear = 2,
        [Display(Name = "Костюми")]
        Costume = 3,
        [Display(Name = "Сорочки")]
        Shirts = 4,
        [Display(Name = "Футболки")]
        Tshirts = 5,
        [Display(Name = "Штани")]
        Pants = 6,
        [Display(Name = "Спортивний")]
        Sport = 7

    }
}
