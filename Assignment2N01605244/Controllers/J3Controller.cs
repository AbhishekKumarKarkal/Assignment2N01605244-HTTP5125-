using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3Controller : ControllerBase
    {
        // <summary>
        /// Calculate the final scores of Sam and Bob after multiple dice rolls.
        /// </summary>
        /// <param name="rounds">Number of rounds</param>
        /// <param name="rolls">Comma-separated list of dice rolls (Alice,Bob)</param>
        /// <returns>The final scores of Alice and Bob</returns>
        [HttpGet("DoubleDice")]
        public IActionResult CalculateScores([FromQuery] int rounds, [FromQuery] string rolls)
        {
            
            string[] diceRolls = rolls.Split(',');
            if (diceRolls.Length != rounds * 2)
            {
                return BadRequest("Invalid input. The number of rolls should match the number of rounds.");
            }

            int samScore = 0;
            int bobScore = 0;

            
            for (int i = 0; i < rounds; i++)
            {
                int samRoll = int.Parse(diceRolls[i * 2]);
                int bobRoll = int.Parse(diceRolls[i * 2 + 1]);

                
                if (samRoll > bobRoll)
                {
                    samScore++;
                }
                else if (bobRoll > samRoll)
                {
                    bobScore++;
                }
                
            }

            
            return Ok($"Final scores - Sam: {samScore}, Bob: {bobScore}");
        }
    }
}

