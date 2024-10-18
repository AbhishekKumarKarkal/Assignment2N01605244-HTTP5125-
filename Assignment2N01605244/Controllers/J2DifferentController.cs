using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2DifferentController : ControllerBase
    {
        /// <summary>
        /// Calculate the speeding fine based on the driver's speed and the speed limit.
        /// </summary>
        /// <param name="speedLimit">The speed limit of the road</param>
        /// <param name="driverSpeed">The speed the driver was going</param>
        /// <returns>The amount of the fine or no fine if within the speed limit</returns>
        [HttpGet("SpeedingFine")]
        public IActionResult FineCalculator([FromQuery] int speedLimit, [FromQuery] int driverSpeed)
        {
            int fine = 0;

            
            int overSpeed = driverSpeed - speedLimit;

            
            if (overSpeed <= 0)
            {
                return Ok("No fine, you are within the speed limit.");
            }
            else if (overSpeed >= 1 && overSpeed <= 20)
            {
                fine = 100;
            }
            else if (overSpeed >= 21 && overSpeed <= 30)
            {
                fine = 270;
            }
            else if (overSpeed > 30)
            {
                fine = 500;
            }

            
            return Ok($"You are speeding and your fine is ${fine}.");
        }
    }

}

