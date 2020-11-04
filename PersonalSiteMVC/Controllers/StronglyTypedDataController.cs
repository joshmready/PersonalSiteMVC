using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSiteMVC.Models; //This is giving access to my models
using System.Net; //This is giving access to the Network Credentials
using System.Net.Mail; // Access to most email functionality

//namespace PersonalSiteMVC.Controllers
//{
//    public class StronglyTypedDataController : Controller
//    {
//        // GET: StronglyTypedData
//        public ActionResult Contact()
//        {
//            return View();
//        }

//        //Post
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Contact(ContactViewModel cvm)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(cvm);
//            }

//            string message = $"You have received an email from {cvm.Name} with a subject {cvm.Subject}. Please respond to {cvm.Email} with your response to the following message: <br/>{cvm.Message}";

//            MailMessage mm = new MailMessage(
//                //From
//                "admin@joshready.com",
//                //To
//                "joshmready@gmail.com",
//                //Subject
//                cvm.Subject,
//                //Body
//                message
//                );

//            mm.IsBodyHtml = true;

//            mm.Priority = MailPriority.High;

//            mm.ReplyToList.Add(cvm.Email);

//            SmtpClient client = new SmtpClient("mail.joshmready.com");

//            client.Credentials = new NetworkCredential("admin@joshready.com", "Chiefs01*");

//            client.Port = 8889;

//            try
//            {
//                client.Send(mm);
//            }
//            catch (Exception ex)
//            {

//                ViewBag.CustomerMessage = $"We are sorry your request could not be completed at this time. Please try again later.<br/>Error Message:<br/>{ex.StackTrace}";
//                return View(cvm);
//            }

//            return View("EmailConfirmation", cvm);
//        }

        
//    }
//}