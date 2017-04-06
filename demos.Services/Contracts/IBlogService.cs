using System.Collections.Generic;
using demos.Models.BindingModels.Blog;
using demos.Models.ViewModels.Blog;

namespace demos.Services.Contracts
{
    public interface IBlogService
    {
        IEnumerable<ArticleViewModel> GetAllArticles();
        void AddArticle(AddArticleBm addArticleBm, string username);
    }
}