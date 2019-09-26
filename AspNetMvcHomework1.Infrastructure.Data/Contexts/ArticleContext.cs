using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AspNetMvcHomework1.Domain.Core.BasicModels;


namespace AspNetMvcHomework1.Infrastructure.Data.Contexts
{
    public class ArticleContext : DbContext
    {
        static ArticleContext()
        {
            Database.SetInitializer(new ArticleInitializer());
        }
        public DbSet<SimpleArticle> SimpleArticles { get; set; }
    }
    class ArticleInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext articleContext)
        {
            articleContext.SimpleArticles.AddRange(new List<SimpleArticle>(){
                new SimpleArticle() { Topic="Topic of first article", Content="Content of first article", PublishedAt = DateTime.Now, ShortDescription="Short descritption of first article"},
                new SimpleArticle { Topic="Topic of second article", Content="Content of second article", PublishedAt = DateTime.Now, ShortDescription="Short descritption of second article"}});
        }
    }
}
