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
            string mailPassword = "9444932329";

            StringBuilder htmlbody = new StringBuilder();
            htmlbody.Append("<table>");
            htmlbody.Append("<tr><th colspan=3><h2> New User contact Details</h2></th></tr>");
            htmlbody.Append("<tr><td>FirstName</td> <td>:</td><td>");
            htmlbody.Append("Thiru");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("<tr><td>LastName</td> <td>:</td><td>");
            htmlbody.Append("Perumal");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("<tr><td>Area</td> <td>:</td><td>");
            htmlbody.Append("Chennai");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("<tr><td>Email Address</td> <td>:</td><td>");
            htmlbody.Append("test@gmail.com");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("<tr><td>Contact Number</td> <td>:</td><td>");
            htmlbody.Append("84575 23568");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("<tr><td>User Message</td> <td>:</td><td>");
            htmlbody.Append("Test");
            htmlbody.Append("</td></tr>");
            htmlbody.Append("</table>");

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
            //address to which mail will be sent.      v 
              
            send_mail.To.Add(new MailAddress("thirunavukkarasu@outlook.com"));
            //subject of the mail.
            send_mail.Subject = "Test Mail VIP 2 VIP";

            //To send the mail give the permission from Gmail https://myaccount.google.com/lesssecureapps 
            send_mail.Body = htmlbody.ToString();
            client.Send(send_mail);
            
            ViewBag.Status = "Success";

            return View(periopContentViewModelList);
        }

    }
}