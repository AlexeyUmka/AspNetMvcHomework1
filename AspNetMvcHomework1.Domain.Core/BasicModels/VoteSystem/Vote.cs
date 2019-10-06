using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem
{
    public class Vote : IVote<Voter, Voting>
    {
        public int VoteID { get; set; }
        [Required]
        public string SelectedOption {get; set; }
        public int? VoterID { get; set; }
        public Voter Voter {get; set; }
        public int? VotingID { get; set; }
        public Voting Voting { get; set; }
    }
}
