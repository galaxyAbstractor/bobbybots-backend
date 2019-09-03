using bobbybots_backend.database;
using bobbybots_backend.entity;
using GraphQL.Types;

namespace bobbybots_backend.GraphQL
{
    public class Query : ObjectGraphType
    {
        public Query()
        {
            Field<RobotType>(
                "bot",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id"}
                ),
                resolve: context =>
                {
                    using (var db = new BotContext()) {
                        return db.Bots;                        
                    }
                });
        }
    }
}