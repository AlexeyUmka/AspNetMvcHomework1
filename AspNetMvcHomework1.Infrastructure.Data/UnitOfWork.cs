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
        #region Private Members

        /// <summary>
        /// A database context of an instance 
        /// </summary>
        private BlogContext db = new BlogContext();

        /// <summary>
        /// A repository for <see cref="AspNetMvcHomework1.Domain.Core.BasicModels.SimpleArticle"/>
        /// </summary>
        private SimpleArticleRepository simpleArticleRepository;

        /// <summary>
        /// A repository for <see cref="AspNetMvcHomework1.Domain.Core.BasicModels.SimpleReview"/>
        /// </summary>
        private SimpleReviewRepository simpleReviewRepository;

        /// <summary>
        /// A repository for <see cref="AspNetMvcHomework1.Domain.Core.BasicModels.SimpleSheet"/>
        /// </summary>
        private SimpleSheetRepository simpleSheetRepository;

        #endregion

        #region Public Properties

        /// <summary>
        /// Get current <see cref="SimpleArticleRepository"/>
        /// </summary>
        public SimpleArticleRepository SimpleArticles
        {
            get
            {
                // if we don't have a repository...
                if (simpleArticleRepository == null)
                    // create new
                    simpleArticleRepository = new SimpleArticleRepository(db);

                // return repository
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

        #endregion

        /// <summary>
        /// Логика сохраниения общая, поэтому этим занимается UnitOfWork
        /// </summary>
        public void Save()
        {
            // save all changes in database
            db.SaveChanges();
        }

        //Очищение тоже общее
        private bool disposed = false;

        /// <summary>
        /// Forced disposing
        /// </summary>
        /// <param name="disposing">Indicates if we want to dispose of a database</param>
        public virtual void Dispose(bool disposing)
        {
            // if an object is not disposed
            if (!this.disposed)
            {
                // if we want to dispose of a database
                if (disposing)
                {
                    // dispose of a databse
                    db.Dispose();
                }

                // we indicate that database shouldn't be disposed anymore
                this.disposed = true;
            }
        }

        /// <summary>
        /// Explicit dispose of a databse and object
        /// </summary>
        public void Dispose()
        {
            // first, dispose of a database
            Dispose(true);

            // garbage collector call for this object
            GC.SuppressFinalize(this);
        }
    }
}
