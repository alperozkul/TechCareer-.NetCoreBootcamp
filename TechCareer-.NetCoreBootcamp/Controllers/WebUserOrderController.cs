using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareer_.NetCoreBootcamp.Context;

namespace TechCareer_.NetCoreBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserOrderController : ControllerBase
    {
        private readonly TechCareerDbContext _context;
        public WebUserOrderController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderWebUsers = _context.WebUsers.Include(x => x.Order).ToList();
            return Ok(orderWebUsers);
        }
    }
}
