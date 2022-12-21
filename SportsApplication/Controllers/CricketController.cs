using Microsoft.AspNetCore.Mvc;
using SportsApplication.Models;
using System.Collections.Generic;

namespace SportsApplication.Controllers
{
    [ApiController]
    [Route("api/cricket")]
    public class CricketController : ControllerBase
    {
        [HttpPost]
        [Route("players/create/list")]

        public void Post([FromBody] List<Cricket> crick)
        {
            using (var cri = new SportsContextClass())
            {
                foreach(var cricket in crick)
                {
                    cri.Crickets.Add(new Cricket() { Id = cricket.Id, Player_Name = cricket.Player_Name, Country = cricket.Country, Age = cricket.Age, Designation = cricket.Designation });
                    cri.SaveChanges();
                }
            }

        }

    }
}
