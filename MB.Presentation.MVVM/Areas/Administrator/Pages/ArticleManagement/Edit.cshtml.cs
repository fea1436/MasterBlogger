using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contract.Article;
using MB.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVVM.Areas.Administrator.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public EditArticleCommand Article { get; set; }

        private readonly IArticleApplication articleApplication;
        private readonly IArticleCategoryApplication articleCategoryApplication;

        public void OnGet(long Id)
        {
        }
    }
}
