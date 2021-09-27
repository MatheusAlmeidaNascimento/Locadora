using Locadora.Domains;
using Locadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        private string stringConexao = @"Data Source=DESKTOP-9THVDDP\SQLEXPRESS; initial catalog=locadora;";

        //private string stringConexao = "Data Source=DESKTOP-9THVDDP; initial catalog=locadora; integrated security=true";
        public void AtualizarIdCorpo(AluguelDomain aluguelAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int IdAluguel, AluguelDomain aluguelAtualizado)
        {
            throw new NotImplementedException();
        }

        public AluguelDomain BuscarPorId(int IdAluguel)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(AluguelDomain novoAluguel)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdAluguel)
        {
            throw new NotImplementedException();
        }

        public List<AluguelDomain> ListarTodos()
        {

            List<AluguelDomain> listaAluguel = new List<AluguelDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = @"SELECT IdAluguel, DataRetirada, DataDevolucao, NomeCliente, NomeModelo
                                            FROM Aluguel
                                            LEFT JOIN Cliente
                                            ON Aluguel.IdCliente = Cliente.IdCliente
                                            LEFT JOIN Veiculo
                                            ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
                                            LEFT JOIN Modelo
                                            ON Veiculo.IdModelo = Modelo.IdModelo;";

                //Abre conexao com o banco de dados
                con.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(querySelectAll, con)) 
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        AluguelDomain aluguel = new AluguelDomain()
                        {
                            IdAluguel = Convert.ToInt32(rdr[0]),
                            Veiculo = new VeiculoDomain()
                            {
                                Modelo = new ModeloDomain()
                                {
                                    NomeModelo = rdr[3].ToString()
                                }
                            }

                        };

                        listaAluguel.Add(aluguel);

                    }

                }

            };

            return listaAluguel;
      
        }
    }
}
