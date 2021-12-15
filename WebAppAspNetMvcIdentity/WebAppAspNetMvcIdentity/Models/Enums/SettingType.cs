using System.ComponentModel.DataAnnotations;

namespace WebAppAspNetMvcIdentity.Models
{
    public enum SettingType
    {
        [Display(Name = "Пароль")]
        Password = 1,
    }
}