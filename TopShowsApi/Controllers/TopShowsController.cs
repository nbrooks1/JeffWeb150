using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopShowsApi.Controllers
{
    public class TopShowsController : ControllerBase
    {

        [HttpGet("/topshows")]
        public ActionResult GetTopShows()
        {
            // go to the database or whatever the heck you do to find this out...
            var response = new List<TopShow>
           {
               new TopShow(1, "Super Fun Show", "Hulu"),
               new TopShow(2, "Grating Kids Sing Along Show", "Netflix"),
               new TopShow(3, "Yet Another StarWars Thing", "Disney+")
           };
            return Ok(new { Data = response });

        }
    }

    public record TopShow(int Id, string Title, string Network);
}
