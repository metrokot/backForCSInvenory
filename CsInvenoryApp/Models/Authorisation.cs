using System.ComponentModel.DataAnnotations;

namespace CsInvenoryApp.Models;

public class Authorisation
{
    [Display(Name = "Имя пользователя")]
    [Required(ErrorMessage = "Нужно ввести имя пользователя")]
    //добавить проверки (Asp.net)
    public string Name { get; set; }
    [Display(Name = "Введите пароль")]
    [Required(ErrorMessage = "Нужно ввести пароль")]
    public string Password { get; set; }
}