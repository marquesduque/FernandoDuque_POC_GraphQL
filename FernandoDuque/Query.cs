using System;
using EntityObject;
using GraphQL;
using GraphQL.Types;

namespace FernandoDuque
{
    public class Query : ObjectGraphType<object>
    {
        public Query(DataMemory data)
        {
            Name = "Query";

            Field<ClienteGet>(
                "cliente_by_id",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the Cliente" }
                ),
                resolve: context => data.GetClienteByIdAsync(context.GetArgument<string>("id"))
            );

            Func<IResolveFieldContext, string, object> func = (context, id) => data.GetClienteByIdAsync(id);

            //FieldDelegate<ClienteGet>(
            //    "cliente",
            //    arguments: new QueryArguments(
            //        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the droid" }
            //    ),
            //    resolve: func
            //);
        }
    }
}
