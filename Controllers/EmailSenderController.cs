using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc2Hockey.Models;

namespace Mvc2Hockey.Controllers
{
    public class EmailSenderController : Controller
    {
        public IActionResult Index()
        {
            var model = new ContactUs();
           
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(ContactUs model)
        {
           var result = SendEmail(model);             
            return View(model);
    }
        public string SendEmail(ContactUs model)
        {

            try
            {

                var client = new SmtpClient("smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("1f7f7e0bc7c3f8", "6ce4d18ce853df"),
                    EnableSsl = true
                };
                client.Send("noreply@codinginfinite.com", model.Email, "Thanks for contacting " + model.Name, model.Message);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
        }
    }
}