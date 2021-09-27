using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Domains
{
    /// <summary>
    /// Classe que representa a entidade  (Tabela) Aluguel
    /// </summary>
    public class AluguelDomain
    {

        public int IdAluguel { get; set; }

        public int IdVeiculo { get; set; }

        public int IdCliente { get; set; }

        public DateTime DataRetirada { get; set; }

        public DateTime DataDevolucao { get; set; }

        public VeiculoDomain Veiculo { get; set; }

        public ClienteDomain Cliente { get; set; }
    }
}
