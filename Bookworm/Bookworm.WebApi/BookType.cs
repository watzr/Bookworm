using Bookworm.WebApi.Models;
using GraphQL.Types;

namespace Bookworm.WebApi
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Name = "Book";
            Description = "BookType";
            Field(t => t.BookId);
            Field(t => t.Isbn10OrAsin, nullable: true);
            Field(t => t.Isbn13, nullable: true);
            Field(t => t.Title);
            Field<NameType>(
                "AuthorName",
                resolve: context => context.Source.AuthorName
            );
            Field<BookFormatTypeEnumType>("BookFormatType", "Book format type");
            Field(t => t.Length, nullable: true);
            Field(t => t.PublishedDate, nullable: true);
        }
    }
}
