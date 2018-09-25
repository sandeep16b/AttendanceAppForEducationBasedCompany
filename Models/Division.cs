using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceAppForEducationBasedCompany.Models
{
    public class Division
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<ClassType> ClassTypes {get; set;}
        public Division()
        {
            ClassTypes = new Collection<ClassType>();
        }
    }

   
}