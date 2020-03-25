using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdemServico.Application;
using OrdemServico.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrdemServico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        [HttpGet("getall")]
        public IEnumerable<Cliente> Get()
        {
            var clientes = _clienteApp.GetAll();
            return clientes;
        }

        [HttpGet("getbyid/{id}")]
        public Cliente GetById(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.GetById(id);
            return cliente;
        }

        [HttpGet("getidwithorders/{id}")]
        public Cliente GetByIdWithOrders(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.ClienteComPedido(id);
            return cliente;
        }
        [HttpPost("add")]
        public void Add([FromBody]Cliente cliente)
        {
            _clienteApp.Add(cliente);
        }

        [HttpPut("update")]
        public void Update([FromBody]Cliente cliente)
        {
            _clienteApp.Update(cliente);
        }
        [HttpDelete("delete")]
        public void Delete(int id)
        {
            _clienteApp.Remove(_clienteApp.GetById(id));
        }
    }
}
