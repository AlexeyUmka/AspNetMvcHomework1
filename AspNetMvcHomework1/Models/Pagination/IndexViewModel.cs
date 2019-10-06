using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcHomework1.Models;

namespace AspNetMvcHomework1.Models.Pagination
{
    public class IndexViewModel
    {
        public ArticleList ArticleList { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}