using System.ComponentModel.DataAnnotations;
namespace Shop.Domain.Enum
{
    public enum Gender
    {
        [Display(Name = "Чоловічий")]
        Man = 0,
        [Display(Name = "Жіночий")]
        Women = 1
    }
}
