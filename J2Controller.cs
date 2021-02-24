using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J2Controller : ApiController
    {
    /// <summary>
    /// The program ask the user for the faces that the two dices have, then prints out the number of ways 10 may be rolled with these two
    /// return "Invalid input" if user input is invalid
    /// </summary>
    /// <param name="dice1">number of face that the first dice has</param>
    /// <param name="dice2">number of face that the second dice has</param>
    /// <returns>number of way to rolls for a combination of 10</returns>
    /// <example>/api/J2/DiceGame/6/8</example>
    /// ---> There are 5 total ways to get the sum 10.

    [Route("api/J2/DiceGame/{dice1}/{dice2}")]
    [HttpGet]
    //: https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf
    public string DiceGame(int dice1, int dice2)
    {
      
      if (dice1 * dice2 <= 0) return "Invalid input";
      else {
        int total = 0;
        if (dice1 + dice2 >= 10)
        {
          for (int i = 1; i <= dice1; i++)
          {
            for (int j = 1; j <= dice2; j++)
            {
              if (i + j == 10) total++;
            }
          }
        }
        return "There are " + total + " total ways to get the sum 10.";
          }
    }
    }
}
