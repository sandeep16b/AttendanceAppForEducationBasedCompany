using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceAppForEducationBasedCompany.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Category> Categories {get; set;}
        public Subject()
        {
            Categories = new Collection<Category>();
        }

    
    }
}