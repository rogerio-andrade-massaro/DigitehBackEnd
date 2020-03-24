using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAustralia.Application;
using ProjetoAustralia.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoAustralia.API.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET api/<controller>
        public IEnumerable<Cliente> Get()
        {
            var clientes = _clienteApp.GetAll();
            return clientes;
        }

        public Cliente GetById(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.GetById(id);
            return cliente;
        }
        public Cliente GetByIdWithOrders(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.ClienteComPedido(id);
            return cliente;
        }
        [HttpPost]
        public void Add([FromBody]Cliente cliente)
        {
            _clienteApp.Add(cliente);
        }

        [HttpPut]
        public void Update([FromBody]Cliente cliente)
        {
            _clienteApp.Update(cliente);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _clienteApp.Remove(_clienteApp.GetById(id));
        }
    }
}
