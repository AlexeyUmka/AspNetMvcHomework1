using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcHomework1.Models
{
    public class Review
    {
        public string Name { get; set; }
        public string ReviewMes { get; set; }
        public DateTime Date { get; set; }
        public Review(string name, string reviewmes)
        {
            Name = name;
            ReviewMes = reviewmes;
            Date = DateTime.Now;
        }
    }
}