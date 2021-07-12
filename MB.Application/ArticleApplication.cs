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
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content,
                command.ArticleCategoryId);
            _articleRepository.Add(article);
        }

        public void Edit(EditArticleCommand command)
        {
            var article = _articleRepository.Get(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.Save();
        }

        public EditArticleCommand Get(long Id)
        {
            var article = _articleRepository.Get(Id);
            return new EditArticleCommand()
            {
                Id = article.Id,
                Title = article.Title,
                Image = article.Image,
                ShortDescription = article.ShortDescription,
                Content = article.Content,
                ArticleCategoryId = article.ArticleCategoryId
            }
        }
    }
}
