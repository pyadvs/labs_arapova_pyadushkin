using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext(); // Создаем экземпляр контекста данных
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books; // Получаем все книги из базы данных
            ViewBag.Books = books; // Передаем список книг в представление через ViewBag

            return View(); // Возвращаем представление Index
        }

        // Действие Buy, отображающее форму для покупки книги
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;// Передаем идентификатор книги в представление через ViewBag
            return View();// Возвращаем представление Buy
        }

        // Действие Buy, обрабатывающее отправку формы покупки книги
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now; // Устанавливаем текущую дату и время для покупки
            db.Purchases.Add(purchase); // Добавляем информацию о покупке в базу данных
            db.SaveChanges(); // Сохраняем изменения в базе данных
            return "Спасибо, " + purchase.Person + ", за покупку!"; // Возвращаем сообщение об успешной покупке
        }
    }

    
}