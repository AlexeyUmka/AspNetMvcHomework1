using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcHomework1.Models.VoteSystem
{
    public class ViewVote
    {
        public int VoteID { get; set; }
        public string SelectedOption { get; set; }
        public ViewVoter Voter{ get; set; }
        public ViewVoting Voting { get; set; }
    }
}