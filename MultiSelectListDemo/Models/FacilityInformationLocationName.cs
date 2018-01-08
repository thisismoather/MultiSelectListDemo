using System.Collections.Generic;

namespace MultiSelectListDemo.Models
{
    public class FacilityInformationLocationName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}