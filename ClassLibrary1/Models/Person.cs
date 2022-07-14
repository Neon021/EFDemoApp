using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EFDataAccessLibrary.Models
{
    public class Person
    {
        public int Id{ get; set; }
        
        [Required, MaxLength(50)]
        public string? FirstName{ get; set; }
        
        [Required, MaxLength(50)]
        public string?  LastName{ get; set; }
        
        [Required]
        public int Age{ get; set; }
        public string? Nationality{ get; set; }
        public List<Adress> Adresses { get; set; } = new List<Adress>();
        public List<Email> EmailAdresses { get; set; } = new List<Email>(); 
    }
}
