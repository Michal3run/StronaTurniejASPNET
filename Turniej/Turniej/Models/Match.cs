using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turniej.Models
{
    public class Match
    {
        public ApplicationUser Player1 { get; set; }
        public ApplicationUser Player2 { get; set; }
        public Tournament Tournament { get; set; }
        public Winner Winner { get; set; }
    }
    public enum Winner
    {
        Player1,
        Player2,
        //Draw ??
        NotPlayedYet
    }
}