using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contract.Article;
using MB.Domain.ArticleAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVVM.Areas.Administrator.Pages.ArticleManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.GetList();
        }
    }
}
