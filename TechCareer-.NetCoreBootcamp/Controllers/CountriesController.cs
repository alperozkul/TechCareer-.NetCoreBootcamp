using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareer_.NetCoreBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly string[] countries = {"Türkiye",
                "ABD",
                "Rusya",
                "Almanya",
                "Fransa",
                "İtalya",
                "Çin",
                "Hindistan",
                "Kanada",
                "Danimarka",
                "Finlandiya",
                "İsveç",
                "İspanya",
                "İrlanda",
                "Japonya",
                "Katar",
                "Litvanya",
                "Macaristan",
                "Polonya",
                "Romanya"
            };
        [HttpGet]
        public string[] Get()
        {           
            return countries;
        }


        [HttpGet("{totalCountries}")]
        public string[] Get(int totalCountries)
        {
            var selectedCountries = countries.Take(totalCountries).ToArray();
            return selectedCountries;
        }

    }

    

}
