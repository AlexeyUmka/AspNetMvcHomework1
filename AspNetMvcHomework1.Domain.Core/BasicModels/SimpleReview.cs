using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleReview : ISimpleReview
    {
        public int SimpleReviewId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 20)]
        public string ReviewMes { get; set; }
        [Required]
        public DateTime PostedAt { get; set; }
    }
}
