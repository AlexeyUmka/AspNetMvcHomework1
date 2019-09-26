using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AspNetMvcHomework1.Domain.Interfaces.BasicInterfaces;
using AspNetMvcHomework1.Infrastructure.Data.Contexts;
using AspNetMvcHomework1.Domain.Core.BasicModels;

namespace AspNetMvcHomework1.Infrastructure.Data.Repositories
{
    public class SimpleSheetRepository
    {
        private BlogContext db;

        public SimpleSheetRepository(BlogContext context)
        {
            this.db = context;
        }

        public IEnumerable<SimpleSheet> GetElementsOfRepository()
        {
            return db.SimpleSheets.ToList();
        }

        public SimpleSheet GetElement(int id)
        {
            return db.SimpleSheets.Find(id);
        }

        public void Create(SimpleSheet Sheet)
        {
            db.SimpleSheets.Add(Sheet);
        }

        public void Update(SimpleSheet Sheet)
        {
            db.Entry(Sheet).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            SimpleSheet SimpleSheet = db.SimpleSheets.Find(id);
            if (SimpleSheet != null)
                db.SimpleSheets.Remove(SimpleSheet);
        }
    }
}
