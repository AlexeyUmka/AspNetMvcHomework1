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
    public class SimpleReviewRepository : IRepository<SimpleReview>
    {
        private BlogContext db;

        public SimpleReviewRepository(BlogContext context)
        {
            this.db = context;
        }

        public List<SimpleReview> GetElementsOfRepository()
        {
            return db.SimpleReviews.ToList();
        }

        public SimpleReview GetElement(int id)
        {
            return db.SimpleReviews.Find(id);
        }

        public void Create(SimpleReview Review)
        {
            db.SimpleReviews.Add(Review);
        }

        public void Update(SimpleReview Review)
        {
            db.Entry(Review).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            SimpleReview SimpleReview = db.SimpleReviews.Find(id);
            if (SimpleReview != null)
                db.SimpleReviews.Remove(SimpleReview);
        }
    }
}
