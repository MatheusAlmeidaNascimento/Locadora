using Locadora.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Interfaces
{
    interface IClienteRepository
    {

        List<ClienteDomain> ListarTodos();

        void Cadastrar(ClienteDomain novoCliente);

        void AtualizarIdCorpo(ClienteDomain clienteAtualizado);

        void AtualizarIdURL(int IdCliente, ClienteDomain clienteAtualizado);

        void Deletar(int IdCliente);

    }
}
