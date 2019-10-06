using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcHomework1.Models.VoteSystem
{
    public class ViewVoting
    {
        public int VotingID { get; set; }
        public string VotingMessage { get; set; }
        public string Options { get; set; }
    }
}