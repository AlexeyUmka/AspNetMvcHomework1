using System;

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
