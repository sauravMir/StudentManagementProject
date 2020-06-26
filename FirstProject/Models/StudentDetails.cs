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

        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string Sex { get; set; }

    }
}
