namespace TechCareer_.NetCoreBootcamp.Models.ORM
{
    public class Order : BaseModel
    {
        public int OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<WebUser> WebUser { get; set; }
    }
}
