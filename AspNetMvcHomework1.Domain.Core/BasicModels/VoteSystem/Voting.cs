using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem;

namespace AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem
{
    public class Voting : IVoting<Vote>
    {
        public int VotingID { get; set; }
        [Required]
        public string VotingMessage {get; set;}
        [Required]
        [MinLength(length: 2)]
        public string Options {get; set;}
    }
}
