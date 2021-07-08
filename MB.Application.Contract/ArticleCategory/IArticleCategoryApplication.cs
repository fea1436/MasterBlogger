using System.Collections.Generic;

namespace MB.Application.Contract.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategoryCommand command);
        void Rename(RenameArticleCategoryCommand command);
        RenameArticleCategoryCommand Get(long Id);
        void Remove(long id);
        void Activate(long id);
    }
}
