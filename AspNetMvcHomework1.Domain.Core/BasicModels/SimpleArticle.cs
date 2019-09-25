using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleArticle : ISimpleArticle
    {
        public int SimpleArticleId { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Topic { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
    }
}
