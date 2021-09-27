using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Domains
{
    public class VeiculoDomain
    {

        public int IdVeiculo { get; set; }

        public int IdEmpresa { get; set; }

        public ModeloDomain Modelo { get; set; }

    }
}
