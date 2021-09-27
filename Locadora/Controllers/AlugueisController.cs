using Locadora.Domains;
using Locadora.Interfaces;
using Locadora.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Controllers
{
    [Produces("appicaton/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class AlugueisController : ControllerBase
    {

        private IAluguelRepository _AluguelRepository { get; set; }

        public AlugueisController() 
        {
            _AluguelRepository = new AluguelRepository();
        }

        [HttpGet]

        public IActionResult Get() 
        {

            List<AluguelDomain> listaAluguel = _AluguelRepository.ListarTodos();

            return Ok(listaAluguel);

        }

    }
}
