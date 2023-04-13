using System.ComponentModel.DataAnnotations;
namespace Shop.Domain.Enum
{
    public enum Age
    {
        [Display(Name = "Від 0 до 3 років")]
        Newborn = 0,
        [Display(Name = "Дошкільне")]
        PreSchool = 1,
        [Display(Name = "Шкільне")]
        School = 2,
        [Display(Name = "Підліткове")]
        Teen = 3,
        [Display(Name = "Доросле")]
        Adult = 4
    }
}
