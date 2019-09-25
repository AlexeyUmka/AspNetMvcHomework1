using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleReview : ISimpleReview
    {
        public int SimpleReviewId { get; set; }
        public string Name { get; set; }
        public string ReviewMes { get; set; }
        public DateTime PostedAt { get; set; }
    }
}
