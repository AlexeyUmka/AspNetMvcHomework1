using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;

namespace AspNetMvcHomework1.Domain.Interfaces.BasicInterfaces
{
    //Благодаря данному интерфейсу хранилище, которое будет реализовывать этот интерфейс,
    //сможет указать тип статей, которые будут в нем хранится(производные от ISimpleArticle)
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetElementsOfRepository();
        T GetElement(int id);
        void Create(T article);
        void Update(T article);
        void Delete(int id);
        void Save();
    }
}
