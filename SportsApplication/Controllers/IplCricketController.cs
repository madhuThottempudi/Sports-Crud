using Microsoft.AspNetCore.Mvc;
using SportsApplication.Models;
using System;
using System.Collections.Generic;

namespace SportsApplication.Controllers
{
    [ApiController]
    [Route("api/ipl_cricket")]

    public class IplCricketController : ControllerBase
    {
        [HttpPost]
        [Route("players/create/list")]

        public void Post([FromBody] List<Ipl> ipl_cr)
        {
            using (var ipl_cri = new SportsContextClass())
            {
                foreach (var ipl in ipl_cr)
                {
                    ipl_cri.Ipls.Add(new Ipl() { Player_Id = ipl.Player_Id, Player_Name = ipl.Player_Name, Ipl_Team = ipl.Ipl_Team, Role = ipl.Role, Bigbash = ipl.Bigbash });
                   
                    ipl_cri.SaveChanges();
                }
            }

        }
    }
}
