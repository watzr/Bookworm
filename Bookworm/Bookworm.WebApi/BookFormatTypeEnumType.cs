using Bookworm.WebApi.Enums;
using GraphQL.Types;

namespace Bookworm.WebApi
{
    public class BookFormatTypeEnumType : EnumerationGraphType<BookFormatType>
    {
        public BookFormatTypeEnumType()
        {
            Name = "BookFormatType";
            Description = "Book format type";
        }
    }
}
