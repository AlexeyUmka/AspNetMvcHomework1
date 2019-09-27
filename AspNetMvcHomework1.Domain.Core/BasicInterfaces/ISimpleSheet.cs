using System.Collections.Generic;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces
{
    public interface ISimpleSheet
    {
        int SimpleSheetId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Wishes { get; set; }
        List<string> Interests { get; set; }
        string Gender { get; set; }
    }
}
