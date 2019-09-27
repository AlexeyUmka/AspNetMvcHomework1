using AspNetMvcHomework1.Domain.Core.BasicInterfaces;
using System.Collections.Generic;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleSheet : ISimpleSheet
    {
        public int SimpleSheetId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Wishes { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        public string Gender { get; set; }
    }
}
