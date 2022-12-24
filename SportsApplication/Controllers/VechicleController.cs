using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using SportsApplication.Models;
using System.Net;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Web.Http;
using RouteAttribute = System.Web.Http.RouteAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace SportsApplication.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehiclesController : ControllerBase
    {
        private object ctx;

        public VehiclesController() { }

        public int Id { get; private set; }
        public string Veh_Name { get; private set; }
        public string Veh_Company { get; private set; }
        public string Veh_Type { get; private set; }
        public float Weight { get; private set; }

        //[HttpPost]
        //[Route("creation/list")]
        //public HttpResponseMessage Post(List<Vehicle> veh_types)
        //{
        //    try
        //    {
        //        using (var vehic = new SportsContextClass())
        //        {
        //            foreach (var vec in veh_types)
        //            {
        //                vehic.Vehicles.Add(new Vehicle() { Id = vec.Id, Veh_Name = vec.Veh_Name, Veh_Company = vec.Veh_Company, Veh_Type = vec.Veh_Type, Weight = vec.Weight });
        //                vehic.SaveChanges();
        //                var message = Request.CreateResponse(HttpStatusCode.Created, veh_types);
        //                message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
        //                return message;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }

        //    //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "inserted success");
        //    //response.Content = new StringContent("hello", Encoding.Unicode);
        //    //response.Headers.CacheControl = new CacheControlHeaderValue()
        //    //{
        //    //    MaxAge = TimeSpan.FromMinutes(20)
        //    // };
        //    //return response;

        //}
        //[HttpPost]
        //[Route("creation/list")]
        //public IEnumerable<Vehicle> Post([FromBody]List<Vehicle> veh)
        //{
        //    //if (!ModelState.IsValid)
        //    //    return (IHttpActionResult)BadRequest("Invalid data");

        //    try
        //    {
        //        using (var ctx = new SportsContextClass())
        //        {
        //            foreach (var vec in veh)
        //            {
        //                ctx.Vehicles.Add(new Vehicle() { Id = vec.Id, Veh_Name = vec.Veh_Name, Veh_Company = vec.Veh_Company, Veh_Type = vec.Veh_Type, Weight = vec.Weight });
        //                ctx.SaveChanges();

        //                //return (IHttpActionResult)Ok("OK");

        //            }
        //            return (IEnumerable<Vehicle>)Ok();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (IEnumerable<Vehicle>)Ok("data not inserted properly");
        //    }
        //    //return (IHttpActionResult)BadRequest();

        //}
        [HttpPost]
        [Route("gduidhui/hcu")]
        public async Task<IHttpActionResult> Post(List<Vehicle> vechi)
        {
            
            if (!ModelState.IsValid)
            {
                return (IHttpActionResult)BadRequest("Invalid data.");
            }
                  
            using (var ctx = new SportsContextClass())
            {
                foreach (var veh in vechi)
                {
                    ctx.Vehicles.Add(new Vehicle()
                    {
                        Id = veh.Id,
                        Vehicle_Name = veh.Vehicle_Name,
                        Veh_Company = veh.Veh_Company,
                        Veh_Type = veh.Veh_Type,
                        Owner_Name = veh.Owner_Name,
                        Weight = veh.Weight
                    });
                    ctx.SaveChanges();
                }
                return (IHttpActionResult)Ok();
            }

        }


    }
}

