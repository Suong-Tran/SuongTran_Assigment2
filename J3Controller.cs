using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J3Controller : ApiController
  {
    /// <summary>
    ///To calculate a distance table that indicates the distance between any two of the cities
    /// of the 5 cities you have encountered 
    /// </summary>
    /// <param name="distance1"> distance from city 1 to city 2</param>
    /// <param name="distance2"> distance from city 2 to city 3</param>
    /// <param name="distance3"> distance from city 3 to city 4</param>
    /// <param name="distance4"> distance from city 4 to city 5</param>
    /// <returns>a table show the distance between each city</returns>
    /// <example>/api/J3/DistanceBetween/3/10/12/5/</example>
    /// ---> 0 3 13 25 30
    ///      3 0 10 22 27
    ///      13 10 0 12 17
    ///      25 22 12 0 5
    ///      30 27 17 5 0

    [Route("api/J3/DistanceBetween/{distance1}/{distance2}/{distance3}/{distance4}")]
    [HttpGet]
    //https://cemc.math.uwaterloo.ca/contests/computing/2018/stage%201/juniorEF.pdf
    public IEnumerable<string> DistanceBetween(int distance1, int distance2, int distance3, int distance4)
    {
      string[] totalDis = new string[5];
      int[] dist = { distance1, distance2, distance3, distance4 };  
      for (int i = 0; i <= 4; i++)
      {
        int total = 0;
        string distStr = "";
        for (int j = 0; j < i; j++)
        {
          for (int k = j; k < i; k++)
          {
            total = total + dist[k];
          }
          distStr = distStr + total + " ";
          total = 0;
        }
           total = 0;
           distStr = distStr + "0 ";
        for (int m = i; m < 4; m++) {
          total = total + dist[m];
          distStr = distStr + total + " ";
        }           
        totalDis[i] = distStr;
      }
      return totalDis;
    }
  }
}
