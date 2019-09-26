using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces
{
    public interface ISimpleReview
    {
        int SimpleReviewId { get; set; }
        string Name { get; set; }
        string ReviewMes { get; set; }
        DateTime PostedAt { get; set; }
    }
}
