using System;
using System.Data;

namespace MB.Domain.ArticleAgg.Exceptions
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
