using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem
{
    public interface IVote<TVoter, TVoting>
    {
        int VoteID { get; set; }
        string SelectedOption { get; set; }
        int? VoterID { get; set; }
        TVoter Voter { get; set; }
        int? VotingID { get; set; }
        TVoting Voting { get; set; }
    }
}
