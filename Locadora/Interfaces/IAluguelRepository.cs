using Locadora.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Interfaces
{
    interface IAluguelRepository
    {
        //Estrutura de métodos da Interface 
        //TipoRetorno NomeMetodo (TipoParametro NomeParametro);
        //void Listar();

        /// <summary>
        /// Retorna todos os generos
        /// </summary>
        /// <returns>Uma lista de generos</returns> 
        List<AluguelDomain> ListarTodos();

        AluguelDomain BuscarPorId(int IdAluguel);

        void Cadastrar(AluguelDomain novoAluguel);

        void AtualizarIdCorpo(AluguelDomain aluguelAtualizado);

        void AtualizarIdURL(int IdAluguel, AluguelDomain aluguelAtualizado);

        void Deletar(int IdAluguel);
    }
}
