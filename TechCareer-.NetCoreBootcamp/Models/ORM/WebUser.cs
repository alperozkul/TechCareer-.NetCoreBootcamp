using System.ComponentModel.DataAnnotations;

namespace TechCareer_.NetCoreBootcamp.Models.ORM
{
    public class WebUser : BaseModel
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
