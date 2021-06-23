using EntityObject;
using GraphQL;
using GraphQL.Types;

namespace FernandoDuque
{

    public class Mutation : ObjectGraphType
    {
        public Mutation(DataMemory data)
        {
            Name = "Mutation";

            Field<ClienteGet>(
                "sacar",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ClientePost>> { Name = "cliente" }
                ),
                resolve: context =>
                {
                    var Cliente = context.GetArgument<Cliente>("cliente");
                    return data.Sacar(Cliente);
                });

            Field<ClienteGet>(
                "depositar",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ClientePost>> { Name = "cliente" }
                ),
                resolve: context =>
                {
                    var Cliente = context.GetArgument<Cliente>("cliente");
                    return data.Depositar(Cliente);
                });
        }
    }
}
