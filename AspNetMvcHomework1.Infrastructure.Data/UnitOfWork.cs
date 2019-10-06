using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcHomework1.Infrastructure.Data.Repositories;
using AspNetMvcHomework1.Infrastructure.Data.Contexts;

namespace AspNetMvcHomework1.Infrastructure.Data
{
    //Unit of work pattern, инкапсулирует логику работы с источниками данных
    //В данном случае наших репозиториев(Паттерн Репозиторий)
    public class UnitOfWork : IDisposable
    {
        private BlogContext db = new BlogContext();
        private SimpleArticleRepository simpleArticleRepository;
        private SimpleReviewRepository simpleReviewRepository;
        private SimpleSheetRepository simpleSheetRepository;
        private VotingRepository votingRepository;
        private VoteRepository voteRepository;
        private VoterRepository voterRepository;
        public BlogContext GetBlogContext()
        {
            return db;
        }
        public VoterRepository Voters
        {
            get
            {
                if (voterRepository == null)
                    voterRepository = new VoterRepository(db);
                return voterRepository;
            }
        }
        public VoteRepository Votes
        {
            get
            {
                if (voteRepository == null)
                    voteRepository = new VoteRepository(db);
                return voteRepository;
            }
        }
        public VotingRepository Votings
        {
            get
            {
                if (votingRepository == null)
                    votingRepository = new VotingRepository(db);
                return votingRepository;
            }
        }
        public SimpleArticleRepository SimpleArticles
        {
            get
            {
                if (simpleArticleRepository == null)
                    simpleArticleRepository = new SimpleArticleRepository(db);
                return simpleArticleRepository;
            }
        }
        public SimpleReviewRepository SimpleReviews
        {
            get
            {
                if (simpleReviewRepository == null)
                    simpleReviewRepository = new SimpleReviewRepository(db);
                return simpleReviewRepository;
            }
        }
        public SimpleSheetRepository SimpleSheets
        {
            get
            {
                if (simpleSheetRepository == null)
                    simpleSheetRepository = new SimpleSheetRepository(db);
                return simpleSheetRepository;
            }
        }
        //Логика сохраниения общая, поэтому этим занимается UnitOfWork
        public void Save()
        {
            db.SaveChanges();
        }
        //Очищение тоже общее
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
