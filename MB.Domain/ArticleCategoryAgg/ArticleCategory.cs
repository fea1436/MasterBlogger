using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Exceptions;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public ICollection<Article> Articles { get; set; }

        public ArticleCategory(string title, IArticleCategoryValidatorService validatorService)
        {
            GuardAgaintsEmptyTitle(title);
            validatorService.CheckThatThisRecordAlreadyExists(title);

            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article>();
        }

        public void Rename(string Title)
        {
            GuardAgaintsEmptyTitle(Title);

            this.Title = Title;
        }

        private void GuardAgaintsEmptyTitle(string Title)
        {
            if (string.IsNullOrWhiteSpace(Title))
                throw new DuplicateRecordExceptions("Title can't be empty!");
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
    }
}
