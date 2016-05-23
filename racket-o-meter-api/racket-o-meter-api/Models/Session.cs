using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace racket_o_meter_api.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Agility { get; set; }
        public double Speed { get; set; }
        public double Power { get; set; }
        public int Hits { get; set; }
        public long Date { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}