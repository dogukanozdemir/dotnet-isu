using ISU_BT_PROJECT.Data;
using ISU_BT_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace ISU_BT_PROJECT.Controllers
{
    public class ContactController : Controller
    {
        private readonly MySQLContext _context;
        public ContactController(MySQLContext context)
        {
            _context = context;
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm form)
        {
            _context.Add(form);
            _context.SaveChanges();

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("test@ingeniumyazilim.com", "denemeingenium1546..");
            smtp.Port = 587;
            smtp.Host = "mail.ingeniumyazilim.com";
            smtp.EnableSsl = true;
            message.To.Add(form.Email);
            message.From = new MailAddress("test@ingeniumyazilim.com");
            message.Subject = form.Subject;
            message.Body = form.Message;
            smtp.Send(message);

            return View();
        }
    }
}
