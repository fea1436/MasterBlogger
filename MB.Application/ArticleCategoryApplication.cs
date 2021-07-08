using System;
using System.Collections.Generic;
using System.Globalization;
using MB.Application.Contract.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidatorService _articleCategoryValidatorService;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidatorService articleCategoryValidatorService)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidatorService = articleCategoryValidatorService;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.GetAll();

            var result = new List<ArticleCategoryViewModel>();
            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel()
                {
                    ID = articleCategory.ID,
                    Title = articleCategory.Title,
                    IsDeleted = articleCategory.IsDeleted,
                    CreationDate = articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture)
                });
            }

            return result;
        }

        public void Create(CreateArticleCategoryCommand command)
        {
            var articleCategory = new ArticleCategory(command.Title, _articleCategoryValidatorService);
            _articleCategoryRepository.Add(articleCategory);
        }

        public void Rename(RenameArticleCategoryCommand command)
        {
            var articleCategory = _articleCategoryRepository.Get(command.Id) ;
            articleCategory.Rename(command.Title);
            _articleCategoryRepository.Save();
        }

        public RenameArticleCategoryCommand Get(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            return new RenameArticleCategoryCommand
            {
                Id = articleCategory.ID,
                Title = articleCategory.Title
            };
        }

        public void Remove(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.Save();
        }
    }
}
