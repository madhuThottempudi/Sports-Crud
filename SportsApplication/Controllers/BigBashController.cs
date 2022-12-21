using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SportsApplication.Models;
using System;
using System.Collections.Generic;

namespace SportsApplication.Controllers
{
    [ApiController]
    [Route("api/bigbash_cricket")]

    public class BigBashCricketController : ControllerBase
    {
        [HttpPost]
        [Route("players/create/list")]

        public void Post([FromBody] List<Bigbash> bigbash_cr)
        {
            using (var bigbash_cri = new SportsContextClass())
            {
                foreach (var bigbash in bigbash_cr)
                {
                    bigbash_cri.Bigbashs.Add
                   (new Bigbash() { Player_Id  = bigbash.Player_Id, Player_Name = bigbash.Player_Name, Player_Cost = bigbash.Player_Cost, Country = bigbash.Country, Details = bigbash.Details });

                    bigbash_cri.SaveChanges();
                }
            }

        }
    }
}
