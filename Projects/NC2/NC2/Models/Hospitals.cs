using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Hospitals
    {
        [Key]
        public int HospitalId { get; set; }

        [StringLength(100)]
        [Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Decision Maker")]
        public string DecisionMaker { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(8)]
        [Display(Name = "Passowrd")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Service")]
        public string Services { get; set; }
    }
}
