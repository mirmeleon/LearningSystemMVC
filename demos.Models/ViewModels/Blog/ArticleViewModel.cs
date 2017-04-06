
using System;

namespace demos.Models.ViewModels.Blog
{
   public class ArticleViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

        public ArticleAuthorViewModel Author { get; set; }
    }
}
