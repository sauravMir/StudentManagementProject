using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProject.Models
{
    public class StudentDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentDetailsId { get; set; }

        public String Address { get; set; }
        public String BloodGroup { get; set; }
        public String Sex { get; set; }

    }
}
