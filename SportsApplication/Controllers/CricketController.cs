using Microsoft.AspNetCore.Mvc;
using SportsApplication.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


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
       
        [HttpGet]
        [Route("players/retrives/list")]
        public IEnumerable<Cricket> GetAllPlayers(int Age)
        {
            using (var cri = new SportsContextClass())
            {
                var data = cri.Crickets.Where(c => c.Age > 30 && c.Age < 35).ToList();
                return data;
            }
        }
        [HttpPut]
        [Route("players/update/list")]
        public void Put([FromBody] List<Cricket> crick)
        {
            using (var cri = new SportsContextClass())
            {
                var data = cri.Crickets.Where(c => c.Player_Name == "virat").FirstOrDefault<Cricket>();
                if (data != null)
                {
                    data.Player_Name = "kohli";
                    cri.SaveChanges();
                }
            }
        }

        [HttpDelete]
        [Route("players/delete/list")]
        public void Delete(int Id)
        {
            using (var cri = new SportsContextClass())
            {
                    var player = cri.Crickets.Where(c => c.Id == Id).FirstOrDefault();
                if(player != null)
                {
                    cri.Crickets.Remove(player);
                    cri.SaveChanges();
                }
                else
                {
                    Console.WriteLine("No Data Found..");
                }
                    
            }
        }
    }
}
 