using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IStringLocalizer<Classes.SharedResource> _sharedLocalizer;
        public HomeController(
            //IStringLocalizer<HomeController> localizer,
            IStringLocalizer<Classes.SharedResource> sharedLocalizer)
        {
            //_localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        //[HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }



        public ActionResult Index()
        {
               ViewData["Dentist"] = _sharedLocalizer["Dentist"];
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ServicesAndPrices()
        {
            return View();
        }
        public ActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointment(Appointment incomingData)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    incomingData.Status = "не обработано";
                    //db.Appointments.Add(incomingData);
                    //db.SaveChanges();

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }

                return RedirectToAction("Appointment", "Home");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ClientMessage clientMessages = new ClientMessage();
            //clientMessages.Id = 1;
            //clientMessages.Name = "Petro";
            //clientMessages.Phone = "test phone";
            //clientMessages.Email = "testmail@mail.com";
            //clientMessages.Date = DateTime.Now;
            //clientMessages.Status = "В обработке";

            return View(clientMessages);
        }

        [HttpPost]
        public ActionResult Contact(ClientMessage incomingData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    incomingData.Date = DateTime.Now;
                    incomingData.Status = "не обработано";
                    //db.ClientMessages.Add(incomingData);
                    //db.SaveChanges();

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
                return RedirectToAction("Contact", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult CallBack(CallBack callBack, string CurrentPage)
        {
            if (ModelState.IsValid)
            {

                //Debug.WriteLine("*** CallBack ***");
                //Debug.WriteLine("Name = " + callBack.Name);
                //Debug.WriteLine("Phone = " + callBack.Phone);

                try
                {
                    callBack.Date = DateTime.Now;
                    callBack.Status = "status";
                    //db.CallBacks.Add(callBack);
                    //db.Entry(callBack).State = EntityState.Added;
                    //db.SaveChanges();
                    //WebMail.SmtpServer = "smtp.gmail.com";
                    //WebMail.SmtpPort = 587;
                    //WebMail.EnableSsl = true;
                    //WebMail.UserName = "tnasergey";
                    //WebMail.Password = "********";
                    //WebMail.From = "tnasergey@gmail.com";
                    //WebMail.Send("tnasergey@live.ru", "RSVP Notification",
                    //    Name + "qqqqqqqqqqqqqqqqqqq");

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }

                return RedirectToAction("Contact", "Home");
            }
            if (CurrentPage == "")
                return View("Contact");
            else
                return View(CurrentPage);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
