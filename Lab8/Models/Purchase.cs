using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Модель для покупки книги
namespace BookStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; } //Уникальный идентификатор покупки.
        public string Person { get; set; } //Имя покупателя.
        public string Address { get; set; } //Адрес доставки покупки.
        public int BookId { get; set; } //Идентификатор книги, которую купил пользователь.
        public DateTime Date { get; set; } //Дата покупки.
    }
}