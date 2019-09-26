using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces
{
    public interface ISimpleArticle
    {
         int SimpleArticleId { get; set; }
         DateTime PublishedAt { get; set; }
         string Topic { get; set; }
         string ShortDescription { get; set; }
         string Content { get; set; }
    }
}
