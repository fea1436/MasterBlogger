using System.Collections.Generic;
using MB.Application.Contract.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
        void Add(Article entity);
        Article Get(long Id);
        void Save();
    }
}
