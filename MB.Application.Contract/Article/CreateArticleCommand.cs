namespace MB.Application.Contract.Article
{
    public class CreateArticleCommand
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Iamge { get; set; }
        public string Content { get; set; }
        public long ArticleCategoryId { get; set; }
    }
}