using FernandoDuque;
using GraphQL.Types;
using System.Collections.Generic;

namespace EntityObject
{
    public class Cliente
    {
        public string Nome { get; set; }
        public decimal Saldo { get; set; }
        public string Id { get; set; }

    }
    public class ClienteGet : ObjectGraphType<Cliente>
    {
        public ClienteGet(DataMemory data)
        {
            Name = "cliente";

            Field(h => h.Id).Description("The id of the Cliente.");
            Field(h => h.Nome).Description("The id of the Cliente.");
            Field(h => h.Saldo).Description("The id of the Cliente.");



        }
    }
    public class ClientePost : InputObjectGraphType<Cliente>
    {
        public ClientePost(Cliente data)
        {
            Name = "clienteInput";

            Field(h => h.Id).Description("The id of the human.");
            Field(h => h.Saldo).Description("The id of the Cliente.");

        }
    }
}
