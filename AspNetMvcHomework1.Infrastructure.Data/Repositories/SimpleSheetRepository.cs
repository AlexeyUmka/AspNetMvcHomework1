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
        private SheetContext db;

        public SimpleSheetRepository()
        {
            this.db = new SheetContext();
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

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
