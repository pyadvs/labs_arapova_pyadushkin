using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Устанавливаем во ViewData приветствие на основе текущего времени
            ViewData["Greeting"] = GetGreeting();
            return View();
        }

        private string GetGreeting()
        {
            var currentTime = DateTime.Now;// Получаем текущее время
            string greeting;// Переменная для хранения приветствия

            // Определяем приветствие в зависимости от текущего времени суток
            if (currentTime.Hour >= 6 && currentTime.Hour < 11)
            {
                greeting = "Доброе утро";
            }
            else if (currentTime.Hour >= 11 && currentTime.Hour < 17)
            {
                greeting = "Добрый день";
            }
            else if (currentTime.Hour >= 17 && currentTime.Hour < 22)
            {
                greeting = "Добрый вечер";
            }
            else
            {
                greeting = "Доброй ночи";
            }
            return greeting; // Возвращаем определенное приветствие
        }

        [HttpGet]
        public ViewResult AcceptForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AcceptForm(GuestResponse guestResponse) 
        {
            if (ModelState.IsValid) // Проверяем, прошла ли валидация модели
            {
                //TODO: Email response to the party owner
                return View("Thanks", guestResponse); // Если модель валидна, возвращаем представление "Thanks" с данными гостя
            }
            else
            {
                return View(); // Если модель не прошла валидацию, возвращаем представление снова
            }
        }
    }
}
