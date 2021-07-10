using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MB.Application.Contract.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();
        }

        public void Create(CreateArticleCommand command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Iamge, command.Content, command.ArticleCategoryId);
            _articleRepository.Add(article);
        }
    }
}
