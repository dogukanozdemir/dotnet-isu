using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ISU_BT_PROJECT.Models
{
    public class ContactForm
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please Enter Fullname")]
        [Display(Name = "Please Enter Fullname")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Subject")]
        [Display(Name = "Please Enter Subject")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Please Enter Message")]
        [Display(Name = "Please Enter Message")]
        public string Message { get; set; }
    }
}
