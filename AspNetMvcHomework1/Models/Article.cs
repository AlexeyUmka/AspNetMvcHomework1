using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcHomework1.Models
{
    public class Article
    {
        public int ArticleID { get; set; }

        public DateTime PublishedAt { get; set; }
        
        public string Topic { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string Content { get; set; }

        public string Tags { get; set; }
    }
}