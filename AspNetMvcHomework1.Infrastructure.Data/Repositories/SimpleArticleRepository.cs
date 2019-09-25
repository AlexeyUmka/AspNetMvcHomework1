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
    public class SimpleArticleRepository : IRepository<SimpleArticle> 
    {
        private ArticleContext db;

        public SimpleArticleRepository()
        {
            this.db = new ArticleContext();
        }

        public IEnumerable<SimpleArticle> GetElementsOfRepository()
        {
            return db.SimpleArticles.ToList();
        }

        public SimpleArticle GetElement(int id)
        {
            return db.SimpleArticles.Find(id);
        }

        public void Create(SimpleArticle article)
        {
            db.SimpleArticles.Add(article);
        }

        public void Update(SimpleArticle article)
        {
            db.Entry(article).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            SimpleArticle SimpleArticle = db.SimpleArticles.Find(id);
            if (SimpleArticle != null)
                db.SimpleArticles.Remove(SimpleArticle);
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
