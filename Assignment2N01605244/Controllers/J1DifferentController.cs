using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1DifferentController : ControllerBase
    {
        /// <summary>
        /// Determine which quadrant the point (x, y) is in.
        /// </summary>
        /// <param name="x">The x-coordinate of the point</param>
        /// <param name="y">The y-coordinate of the point</param>
        /// <returns>The quadrant number (1, 2, 3, or 4)</returns>
        [HttpGet("Quadrant")]
        public IActionResult QuadrantDeterminant([FromQuery] int x, [FromQuery] int y)
        {
            if (x == 0 || y == 0)
            {
                return BadRequest("x and y must be non-zero.");
            }



            int quadrant = 0;
            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            }

            
            return Ok($"The point ({x}, {y}) is in quadrant {quadrant}.");
        }
    }
}

