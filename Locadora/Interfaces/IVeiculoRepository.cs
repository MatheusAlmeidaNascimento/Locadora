using Locadora.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Interfaces
{
    interface IVeiculoRepository
    {

        List<VeiculoDomain> ListarTodos();

        void Cadastrar(VeiculoDomain novoVeiculo);

        void AtualizarIdCorpo(VeiculoDomain veiculoAtualizado);

        void AtualizarIdURL(int IdVeiculo, VeiculoDomain veiculoAtualizado);

        void Deletar(int IdVeiculo);

    }
}
