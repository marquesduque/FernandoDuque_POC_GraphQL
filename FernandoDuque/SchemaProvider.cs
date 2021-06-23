using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace FernandoDuque
{
    public class SchemaProvider : Schema
    {
        public SchemaProvider(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<Query>();
            Mutation = provider.GetRequiredService<Mutation>();
        }
    }
}
