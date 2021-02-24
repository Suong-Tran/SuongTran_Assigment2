using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J1Controller : ApiController

    {
    /// <summary>
    /// The program asks user for their choice for their meal, then prints out on the screen the total Calories of the selected meal
    /// return "Invalid input" if user input is invalid
    /// </summary>
    /// <param name="burger">choice of burger</param>
    /// <param name="drink">choice of drink</param>
    /// <param name="side">choice of side dish</param>
    /// <param name="dessert">choice of dessert</param>
    /// <returns>number of calories in a meal</returns>
    /// <example>/api/J1/Menu/1/2/3/4</example>
    /// ---> Your total calorie count is 691


    [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
    [HttpGet]
    // https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf
    public string Menu(int burger, int drink, int side, int dessert)
    {
      if (burger * drink * side * dessert < 0 || burger > 4 || drink > 4 || side > 4 || dessert > 4)
      {
        return "Invalid input";
      }
      else
      {
        int total = 0;
        switch (burger)
        {
          case 1:
            total = total + 461;
            break;
          case 2:
            total = total + 431;
            break;
          case 3:
            total = total + 420;
            break;
          default:
            break;
        }
        switch(drink)
        {
          case 1:
            total = total + 130;
          break;
          case 2:
            total = total + 160;
          break;
          case 3:
            total = total + 118;
          break;
          default:
            break;
        }
        switch (side)
        {
          case 1:
            total = total + 100;
            break;
          case 2:
            total = total + 57;
            break;
          case 3:
            total = total + 70;
            break;
          default:
            break;
        }
        switch (dessert)
        {
          case 1:
            total = total + 167;
            break;
          case 2:
            total = total + 266;
            break;
          case 3:
            total = total + 75;
            break;
          default:
            break;
        }
        return "Your total calories count is " + total;
      }
    }
    }
}
