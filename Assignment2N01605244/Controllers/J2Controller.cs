using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {
        private readonly Dictionary<string, int> PepperHeatUnits = new Dictionary<string, int>
        {
            {"Poblano", 1500},
            {"Mirasol", 6000},
            {"Serrano", 15500},
            {"Cayenne", 40000},
            {"Thai", 75000},
            {"Habanero", 125000}
        };

        /// <summary>
        /// Calculate the total spiciness of the chili based on the peppers used.
        /// </summary>
        /// <param name="ingredients">Comma-separated list of pepper names</param>
        /// <returns>Total spiciness in SHU (Scoville Heat Units)</returns>
        [HttpGet("ChiliPeppers")]
        public int CalculateSpiciness([FromQuery] string Ingredients)
        {
            var Peppers = Ingredients.Split(',');
            int totalSpiciness = Peppers.Sum(Pepper => PepperHeatUnits.GetValueOrDefault(Pepper.Trim(), 0));

            return totalSpiciness;
        }
    }
}
