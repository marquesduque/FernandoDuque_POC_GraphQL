using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using EntityObject;

namespace FernandoDuque
{
    public class DataMemory
    {
        private readonly List<Cliente> _Cliente = new List<Cliente>();

        public DataMemory()
        {
            _Cliente.Add(new Cliente
            {
                Id = "1",
                Nome = "Piter",
                Saldo = 100
            });
            _Cliente.Add(new Cliente
            {
                Id = "2",
                Nome = "Bruce",
                Saldo = 500
            });
            _Cliente.Add(new Cliente
            {
                Id = "3",
                Nome = "Stark",
                Saldo = 1000
            });

        }

        public Task<Cliente> GetClienteByIdAsync(string id)
        {

            return Task.FromResult(_Cliente.FirstOrDefault(h => h.Id == id));
        }


        public Cliente Sacar(Cliente cliente)
        {
            var Cliente = _Cliente.FirstOrDefault(c => c.Id == cliente.Id);
            if (Cliente == null)
            {
                throw new Exception("Cliente não encontrado");
            }
            if (Cliente.Saldo < cliente.Saldo)
            {
                throw new Exception("Saldo Insuficiente");
            }
            Cliente.Saldo = Cliente.Saldo - cliente.Saldo;

            return Cliente;
        }
        public Cliente Depositar(Cliente cliente)
        {
            var Cliente = _Cliente.FirstOrDefault(c => c.Id == cliente.Id);
            if (Cliente == null)
            {
                throw new Exception("Cliente não encontrado");
            }
            Cliente.Saldo = Cliente.Saldo + cliente.Saldo;

            return Cliente;
        }
    }
}
