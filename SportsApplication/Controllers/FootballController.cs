using Microsoft.AspNetCore.Mvc;
using SportsApplication.Models;
using System.Collections.Generic;

namespace SportsApplication.Controllers
{
    [ApiController]
    [Route("api/football")]
    public class FootballController : ControllerBase
    {

        [HttpPost]
        [Route("players/create/list")]

        public void Post([FromBody] List<Football> soccer)
        {
            using (var socer = new SportsContextClass())
            {
                foreach (var foot in soccer)
                {
                    socer.Footballs.Add(new Football() 
                    { Player_Id = foot.Player_Id, Player_Name = foot.Player_Name, Tropies = foot.Tropies, PlayerRefId = foot.PlayerRefId }
                    );

                    socer.SaveChanges();
                }
            }

        }
    }
}
