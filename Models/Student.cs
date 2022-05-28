using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        public int Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Fname { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        public int Email { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Mobile { get; set; }

        public int Description { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name="Department")]
        public int DepID { get; set; }


        [NotMapped]
        public string Department { get; set; }

    }
}
