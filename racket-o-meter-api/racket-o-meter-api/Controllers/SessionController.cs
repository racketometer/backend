using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using racket_o_meter_api.Models;

namespace racket_o_meter_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SessionController : ApiController
    {

        // The get Epoch time is inspired by this stackoverflow question answer by SLaks:
        // http://stackoverflow.com/questions/5955883/datetimes-representation-in-milliseconds
        [HttpGet]
        public IHttpActionResult Get()
        {
            var session1 = new Session()
            {
                Agility = 12.2,
                Date = (long)(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds,
                Description = "Awesome workout! had so much energy!",
                Hits = 232,
                Id = 5,
                Latitude = 56.193846,
                Longitude = 10.247143,
                Power = 8.1,
                Speed = 10.6,
                UserId = 1
            };
            var session2 = new Session()
            {
                Agility = 11.8,
                Date = (long)(DateTime.Now.AddDays(-3).AddHours(-2) - new DateTime(1970, 1, 1)).TotalMilliseconds,
                Description = "Good match against Kim",
                Hits = 325,
                Id = 4,
                Latitude = 56.193846,
                Longitude = 10.247143,
                Power = 7.9,
                Speed = 10.5,
                UserId = 1
            };
            var session3 = new Session()
            {
                Agility = 11.1,
                Date = (long)(DateTime.Now.AddDays(-9) - new DateTime(1970, 1, 1)).TotalMilliseconds,
                Description = "Didnt feel well today",
                Hits = 189,
                Id = 3,
                Latitude = 56.193846,
                Longitude = 10.247143,
                Power = 7.1,
                Speed = 7.9,
                UserId = 1
            };
            var session4 = new Session()
            {
                Agility = 11.7,
                Date = (long)(DateTime.Now.AddDays(-11).AddHours(-2) - new DateTime(1970, 1, 1)).TotalMilliseconds,
                Description = "Great second practice! learning alot",
                Hits = 183,
                Id = 2,
                Latitude = 56.193846,
                Longitude = 10.247143,
                Power = 7.6,
                Speed = 9.8,
                UserId = 1
            };
            var session5 = new Session()
            {
                Agility = 11.5,
                Date = (long)(DateTime.Now.AddDays(-14).AddHours(-2) - new DateTime(1970, 1, 1)).TotalMilliseconds,
                Description = "First practice!",
                Hits = 268,
                Id = 1,
                Latitude = 56.193846,
                Longitude = 10.247143,
                Power = 7.2,
                Speed = 9.6,
                UserId = 1
            };

            var sessions = new List<Session> {session1, session2, session3, session4, session5};

            return Ok(sessions);
        }
    }
}
