using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введите свое имя")]//Обязательное поле для заполнения, если ошибка - сообщение "Введите свое имя"
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите свой email")] // Проверка на соответствие регулярному выражению, если ошибка - сообщение "Введите корректный email"
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Введите корректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите свой номер телефона")] // Обязательное поле для заполнения, если ошибка - сообщение "Введите свой номер телефона"
        public string Phone {  get; set; }

        [Required(ErrorMessage = "Введите свой возраст")] // Обязательное поле для заполнения, если ошибка - сообщение "Введите свой возраст"
        [Range(18, int.MaxValue, ErrorMessage = "Извините, вечеринка только для совершеннолетних")] // Проверка на диапазон значений, если ошибка - сообщение "Извините, вечеринка только для совершеннолетних"
        public int Age { get; set; }

        [Required(ErrorMessage = "Выберите один из вариантов")] // Обязательное поле для заполнения, если ошибка - сообщение "Выберите один из вариантов"
        public bool? WillAttend { get; set; }
        public bool? WillAttend { get; set; }
    }
}
