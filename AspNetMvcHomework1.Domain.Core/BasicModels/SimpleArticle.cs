using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleArticle : ISimpleArticle
    {
        public int SimpleArticleId { get; set; }
        [Required]
        public DateTime PublishedAt { get; set; }
        [Required]
        [StringLength(50)]
        public string Topic { get; set; }
        [StringLength(50)]
        public string ShortDescription { get; set; }
        [Required]
        public string Content { get; set; }
        public string Tags { get; set; }
    }
}
