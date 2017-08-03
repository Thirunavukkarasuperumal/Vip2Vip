using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Vip2Vip.Models;

namespace Vip2Vip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //MailRepository repository = new MailRepository();
            //var periopContentList = repository.GetAllPeriopContent();
            var periopContentViewModelList = new List<PeriopContentViewModel>();
            //PeriopContentViewModel periopContentViewModel;
            //foreach (var item in periopContentList)
            //{
            //    periopContentViewModel = new PeriopContentViewModel();
            //    periopContentViewModel.CourseID = item.CourseID;
            //    periopContentViewModel.CourseType = item.CourseType;
            //    periopContentViewModel.Description = item.Description;
            //    periopContentViewModel.IsActive = item.IsActive;
            //    periopContentViewModel.TemplateID = item.TemplateID;
            //    periopContentViewModelList.Add(periopContentViewModel);
            //}

            string fromAddress = "thirushr@gmail.com";
            string mailPassword = "X";

            StringBuilder htmlbody = new StringBuilder();

            UserRepository userRepository = new UserRepository();
            var userModelList = userRepository.GetAllUserDetails();
            foreach (var user in userModelList)
            {
                htmlbody.Append("Dear Rtr." + user.Name + ",<br /><br />");
                htmlbody.Append("We are pleased to offer you the position of <b>“" + user.Position + "”</b> with <b>Rotaract club of Deepam</b> for the year " + user.Year + ".<br/><br/>");
                htmlbody.Append("We welcome all your ideas and suggestions to improve the club activities <br/><br/>");
                htmlbody.Append("We are expecting you to presence on all the special occasion in association with Rotaract club of Deepam.<br/><br/>");
                htmlbody.Append("Regards,<br/>Rtr." + user.Name + ",<br />" + user.Position + "(" + user.Year + ")<br/>Mobile: +91 98400 14924.<br/>E - Mail: thirunavukkarasu@outlook.com");

                // Create smtp connection.
                SmtpClient client = new SmtpClient();
                client.Port = 587;//outgoing port for the mail.
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(fromAddress, mailPassword);


                // Fill the mail form.
                var send_mail = new MailMessage();

                send_mail.IsBodyHtml = true;
                //address from where mail will be sent.
                send_mail.From = new MailAddress("thirushr@gmail.com");
                //address to which mail will be sent.     

                send_mail.To.Add(new MailAddress("thirunavukkarasu@outlook.com"));
                //subject of the mail.
                send_mail.Subject = "Test Mail VIP 2 VIP";

                //To send the mail give the permission from Gmail https://myaccount.google.com/lesssecureapps 
                send_mail.Body = htmlbody.ToString();
                client.Send(send_mail);
            }
            ViewBag.Status = "Success";

            return View(periopContentViewModelList);
        }

    }
}