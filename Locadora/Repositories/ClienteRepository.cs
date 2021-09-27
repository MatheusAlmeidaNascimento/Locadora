using Locadora.Domains;
using Locadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public void AtualizarIdCorpo(ClienteDomain clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int IdCliente, ClienteDomain clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClienteDomain novoCliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
