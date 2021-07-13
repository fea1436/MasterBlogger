using System.Data;
using MB.Domain.ArticleAgg.Exceptions;

namespace MB.Domain.ArticleAgg.Services
{
    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CheckThatThisArticleAlreadyExists(string Title)
        {
            if (_articleRepository.Exists(Title))
                throw new DuplicateRecordExceptions("This record already exists in database!");
        }
    }
}
