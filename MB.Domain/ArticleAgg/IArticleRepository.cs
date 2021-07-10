using System.Collections.Generic;
using MB.Application.Contract.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
    }
}
