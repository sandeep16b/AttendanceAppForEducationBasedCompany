using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AttendanceAppForEducationBasedCompany.Models
{
    public class ClassType
    {
        public int Id { get; set; }
       
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public Division Division{ get; set; }
        public int DivisionId { get; set; }

       
        public ICollection<Location> Locations {get; set;}
        public ClassType()
        {
           
            Locations = new Collection<Location>();
        }

    }
}