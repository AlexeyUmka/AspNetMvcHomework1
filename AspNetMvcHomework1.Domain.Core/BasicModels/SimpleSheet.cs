using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcHomework1.Domain.Core.BasicModels
{
    public class SimpleSheet : ISimpleSheet
    {
        public int SimpleSheetId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Surname { get; set; }
        [Required]
        [StringLength(255)]
        public string Wishes { get; set; }
        public List<string> Interests { get; set; } = new List<string>();
        [Required]
        public string Gender { get; set; }
    }
}
