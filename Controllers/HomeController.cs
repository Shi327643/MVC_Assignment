using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FeedbackForm()
        {
            ViewBag.Message = "Your contact page.";
            var list = new List<string>() { "Machine Learning", "AI", "AR/VR", "NLP", "Dot Net" };
            ViewBag.list = list;
            return View();
        }
        //[HttpPost]
        public ActionResult SuccessFullForm(Feedback feedback)
        {
            //return RedirectToAction("SuccessFullForm");
            ViewBag.feedback = "Thank you" + " " + feedback.StudentName + " " + "for your feedback";
            return View(feedback);
            

        }
        public ActionResult Validate()
        {
            return View();
            
            
        }
        public ActionResult ValidationConfirmation(ValidateUser user)
        {
            string username = user.UserName;
            string password = user.Password;    
            if(username == "admin" && password == "123")
            {
                return RedirectToAction("FeedBackForm"); // Redirecting to FeedbackForm
            }
            else
            {

                ViewBag.Message = "Invalid Username or Password";
                return View("Validate", user);
                
            }
        }


    }
}