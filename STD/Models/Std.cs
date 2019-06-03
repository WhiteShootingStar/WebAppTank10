using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STD.Models
{
    public class Std
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Bad First Name"),MaxLength(35)]
        [Display(Name ="First Name" )]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bad Last Name"), MaxLength(35)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bad Studies Name"),MaxLength(35)]
        [Display(Name ="Studies")]
        public string Studies { get; set; }
    }
}
