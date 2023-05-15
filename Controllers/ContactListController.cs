using ISU_BT_PROJECT.Data;
using ISU_BT_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISU_BT_PROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactListController : ControllerBase
    {
        private readonly MySQLContext _context;
        public ContactListController(MySQLContext context) { 
            _context = context;
        }

        // GET: api/<ContactListController>
        [HttpGet]
        public IEnumerable<ContactForm> Get()
        {
            return _context.ContactForms.ToList();
        }

        // GET api/<ContactListController>/5
        [HttpGet("{id}")]
        public ContactForm Get(int id)
        {
            return _context.ContactForms.Find(id);
        }

        // PUT api/<ContactListController>/5
        [HttpPut("{id}")]
        public ContactForm Put(int id, [FromBody] ContactForm form)
        {
            ContactForm contactForm = _context.ContactForms.Find(id);
            contactForm.Fullname = form.Fullname;
            contactForm.Email = form.Email;
            contactForm.Message = form.Message;
            contactForm.Subject = form.Subject;
            _context.Entry(contactForm).State = EntityState.Modified;
            _context.SaveChanges();
            return contactForm;


        }

        // DELETE api/<ContactListController>/5
        [HttpDelete("{id}")]
        public Boolean Delete(int id)
        {
            var contactToDelete = _context.ContactForms.Find(id);
            if(contactToDelete != null)
            {
                _context.Remove(contactToDelete);
                _context.SaveChanges();
                return true;
            } else
            {
                return false;
            }
        }
    }
}
