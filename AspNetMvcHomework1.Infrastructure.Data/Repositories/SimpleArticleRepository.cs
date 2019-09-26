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
        private BlogContext db;

        public SimpleArticleRepository(BlogContext context)
        {
            this.db = context;
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
    }
}
