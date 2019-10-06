using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces;

namespace AspNetMvcHomework1.Models
{
    public class ArticleList
    {
        public List<Article> Articles { get; set; } = new List<Article>();
    }
    public static class ExtensionsMethodsForArticles
    {
        public static void AddSimpleArticles(this List<Article> articles, IEnumerable<ISimpleArticle> simpleArticles)
        {
            foreach (var simpleArticle in simpleArticles)
                articles.Add(new Article() { Topic = simpleArticle.Topic, Content = simpleArticle.Content, ShortDescription = simpleArticle.ShortDescription, PublishedAt = simpleArticle.PublishedAt, ArticleID=simpleArticle.SimpleArticleId, Tags=simpleArticle.Tags});
        }
        public static void AddSimpleArticle(this List<Article> articles, ISimpleArticle simpleArticle)
        {
            articles.Add(new Article() { Topic = simpleArticle.Topic, Content = simpleArticle.Content, ShortDescription = simpleArticle.ShortDescription, PublishedAt = simpleArticle.PublishedAt, ArticleID = simpleArticle.SimpleArticleId, Tags=simpleArticle.Tags});
        }
    }
}