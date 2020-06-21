using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modele
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string email { get; set; }
        
        public List<Perscription> Prescriptions { get; set; }
    }
}