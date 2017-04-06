using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using demos.Models;
using demos.Models.BindingModels.Blog;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Blog;
using demos.Services.Contracts;

namespace demos.Services
{
  public class BlogService : Service, IBlogService
  {
        public IEnumerable<ArticleViewModel> GetAllArticles()
        {
            IEnumerable<Article> articles = this.Context.Articles;
            IEnumerable<ArticleViewModel>  mapped = Mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(articles);
            return mapped;
        }

        public void AddArticle(AddArticleBm addArticleBm, string username)
        {
            ApplicationUser currentUser = this.Context.Users.FirstOrDefault(u => u.UserName == username);
            Article article = Mapper.Map<AddArticleBm, Article>(addArticleBm);
            article.Author = currentUser;
            article.PublishDate = DateTime.Today;
            this.Context.Articles.Add(article);
            this.Context.SaveChanges();
        }
    }
}
