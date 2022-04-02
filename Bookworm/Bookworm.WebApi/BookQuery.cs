using Bookworm.WebApi.Data;
using GraphQL.Types;

namespace Bookworm.WebApi
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery()
        {
            Field<ListGraphType<BookType>>(
                "Book",
                resolve: context => BookMockData.GetBooks()
            );
        }
    }
}
