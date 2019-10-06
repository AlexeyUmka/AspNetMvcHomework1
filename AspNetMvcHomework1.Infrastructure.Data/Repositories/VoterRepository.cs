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
    public class VoterRepository:IRepository<Voter>
    {
        private BlogContext db;

        public VoterRepository(BlogContext context)
        {
            this.db = context;
        }

        public List<Voter> GetElementsOfRepository()
        {
            return db.Voters.ToList();
        }

        public Voter GetElement(int id)
        {
            return db.Voters.Find(id);
        }

        public void Create(Voter voter)
        {
            db.Voters.Add(voter);
        }

        public void Update(Voter voter)
        {
            db.Entry(voter).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Voter Voter = db.Voters.Find(id);
            if (Voter != null)
                db.Voters.Remove(Voter);
        }
    }
}
