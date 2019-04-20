using GraphQL.Types;
using GraphQLTest.Entities;

namespace GraphQLTest.Queries.Types
{
    public class RatingType : ObjectGraphType<Comment>
    {
        public RatingType()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}
