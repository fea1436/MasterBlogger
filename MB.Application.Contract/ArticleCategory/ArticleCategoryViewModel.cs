namespace MB.Application.Contract.ArticleCategory
{
    public class ArticleCategoryViewModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string CreationDate { get; set; }
    }
}
