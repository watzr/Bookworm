using Bookworm.WebApi.Models;
using GraphQL.Types;

namespace Bookworm.WebApi
{
    public class NameType : ObjectGraphType<Name>
    {
        public NameType()
        {
            Name = "Name";
            Description = "NameType";
            Field(t => t.FirstName);
            Field(t => t.LastName);
        }
    }
}
