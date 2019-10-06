using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AspNetMvcHomework1.Domain.Interfaces.BasicInterfaces;
using AspNetMvcHomework1.Infrastructure.Data.Contexts;
using AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem;


namespace AspNetMvcHomework1.Infrastructure.Data.Repositories
{
    public class VoteRepository : IRepository<Vote>
    {
        private BlogContext db;

        public VoteRepository(BlogContext context)
        {
            this.db = context;
        }

        public List<Vote> GetElementsOfRepository()
        {
            return db.Votes.ToList();
        }

        public Vote GetElement(int id)
        {
            return db.Votes.Find(id);
        }

        public void Create(Vote Vote)
        {
            db.Votes.Add(Vote);
        }

        public void Update(Vote Vote)
        {
            db.Entry(Vote).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Vote Vote = db.Votes.Find(id);
            if (Vote != null)
                db.Votes.Remove(Vote);
        }
    }
}
