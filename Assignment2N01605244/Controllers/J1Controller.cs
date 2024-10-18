using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1Controller : ControllerBase
    {
        /// <summary>
        /// Calculate the final score for Deliv-e-droid.
        /// </summary>
        /// <param name="Collisions">Number of Collisions</param>
        /// <param name="Deliveries">Number of Deliveries</param>
        /// <returns>The final score</returns>

        [HttpPost("Delivedroid")]
        public int ScoreCalculate([FromForm] int Collisions, [FromForm] int Deliveries) {

            int score = (Deliveries * 50) - (Collisions * 10);

            if (Deliveries > Collisions)
            {
                score = score + 500 ;
            }     
            
            return score;
        
        }



    }
}
