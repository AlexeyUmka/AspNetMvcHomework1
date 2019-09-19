using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcHomework1.Models
{
    public class SheetInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Wishes { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public string Gender { get; set; }
    }
}