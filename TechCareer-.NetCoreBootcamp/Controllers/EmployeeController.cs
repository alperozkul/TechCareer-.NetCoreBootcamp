using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechCareer_.NetCoreBootcamp.Context;
using TechCareer_.NetCoreBootcamp.Models;
using TechCareer_.NetCoreBootcamp.Models.ORM;

namespace TechCareer_.NetCoreBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly TechCareerDbContext _context;
        public EmployeeController() 
        { 
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _context.Employees.ToList();
            return Ok(employee);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else return Ok(employee);

        }


        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employee.CreatedAt = DateTime.Now;           
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status201Created, employee);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            var existingEmployee = _context.Employees.Find(id);

            if (existingEmployee == null)
            {
                return NotFound();
            }

            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Address = employee.Address;
            existingEmployee.City = employee.City;
            existingEmployee.BirthDate = employee.BirthDate;
            existingEmployee.UpdatedAt = DateTime.Now;
            _context.Employees.Update(existingEmployee);
            _context.SaveChanges();
            return Ok(existingEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return Ok(employee);
            }
        }
    }
}
