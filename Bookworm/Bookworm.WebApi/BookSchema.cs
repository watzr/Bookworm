using GraphQL.Types;

namespace Bookworm.WebApi
{
    public class BookSchema : Schema
    {
        public BookSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<BookQuery>();
        }
    }
}
