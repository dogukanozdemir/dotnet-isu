using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ISU_BT_PROJECT.Models
{
    public class BTUser
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "Please Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Please Enter Password")]
        public string Password { get; set; }
    }
}
