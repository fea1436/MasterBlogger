using System;

namespace MB.Domain.ArticleCategoryAgg.Exceptions
{
    public class DuplicateRecordExceptions : Exception
    {
        public DuplicateRecordExceptions()
        {
            
        }

        public DuplicateRecordExceptions(string message) : base(message)
        {
            
        }
    }
}
