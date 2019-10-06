using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem
{
    public interface IVoting<TVotes>
    {
        int VotingID { get; set; }
        string VotingMessage { get;set;}
        string Options { get; set; }
    }
}
