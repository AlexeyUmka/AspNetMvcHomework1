using AspNetMvcHomework1.Domain.Core.BasicInterfaces;
using System;

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
