using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem;

namespace AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem
{
    public class Voter : IVoter
    {
        public int VoterID { get; set; }
    }
}
