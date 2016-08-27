using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turniej.Models
{
    public class Tournament
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sport { get; set; } //dyscyplina
        public ApplicationUser Owner { get; set; } //ten któy założył
        public List<ApplicationUser> Players { get; set; }
        public int MaxOccupancy { get; set; }
        public List<string> SponsorLinks { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public DateTime Deadline { get; set; } //termin zgłoszenia
        public Tournament()
        {
            this.Players = new List<ApplicationUser>();
            this.SponsorLinks = new List<string>();
        }
    }   
}