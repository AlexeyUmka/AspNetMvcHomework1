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
    public class VotingRepository : IRepository<Voting>
    {
        private BlogContext db;

        public VotingRepository(BlogContext context)
        {
            this.db = context;
        }

        public List<Voting> GetElementsOfRepository()
        {
            return db.Votings.ToList();
        }

        public Voting GetElement(int id)
        {
            return db.Votings.Find(id);
        }

        public void Create(Voting voting)
        {
            db.Votings.Add(voting);
        }

        public void Update(Voting voting)
        {
            db.Entry(voting).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Voting Voting = db.Votings.Find(id);
            if (Voting != null)
                db.Votings.Remove(Voting);
        }
    }
}
