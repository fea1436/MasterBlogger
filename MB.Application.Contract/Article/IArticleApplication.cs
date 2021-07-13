using System.Collections.Generic;
using MB.Application.Contract.ArticleCategory;

namespace MB.Application.Contract.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetList();
        void Create(CreateArticleCommand command);
        void Edit(EditArticleCommand command);
        EditArticleCommand Get(long Id);
        void Remove(long Id);
        void Activate(long Id);
    }
}
