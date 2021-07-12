namespace MB.Application.Contract.Article
{
    public class EditArticleCommand : CreateArticleCommand
    {
        public long Id { get; set; }
    }
}