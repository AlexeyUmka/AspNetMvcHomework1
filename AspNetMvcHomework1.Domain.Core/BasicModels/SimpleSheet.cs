using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleSheet : ISimpleSheetInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Wishes { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public string Gender { get; set; }
    }
}
