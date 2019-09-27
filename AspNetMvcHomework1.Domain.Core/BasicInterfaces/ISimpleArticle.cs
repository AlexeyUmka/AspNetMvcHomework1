using System;

namespace AspNetMvcHomework1.Domain.Core.BasicInterfaces
{
    /// <summary>
    /// An interface for an article
    /// </summary>
    public interface ISimpleArticle
    {
         /// <summary>
         /// An id for this article
         /// </summary>
         int SimpleArticleId { get; set; }

         /// <summary>
         /// Pblish date of an article
         /// </summary>
         DateTime PublishedAt { get; set; }

         /// <summary>
         /// A title of an article
         /// </summary>
         string Topic { get; set; }

         /// <summary>
         /// Desciption of a main content
         /// </summary>
         string ShortDescription { get; set; }

         /// <summary>
         /// Main content
         /// </summary>
         string Content { get; set; }
    }
}
