using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modele
{
    public class Perscription
    {
        [Key]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        
        
        public int IdPatient { get; set; }
        public Patient patient { get; set; }
        
        public int IdDoctor { get; set; }
        public Doctor doctor { get; set; }
        
    }
}