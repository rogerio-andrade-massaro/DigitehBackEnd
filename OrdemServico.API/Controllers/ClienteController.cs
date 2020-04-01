using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrdemServico.Application;
using OrdemServico.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrdemServico.API.Controllers
{
    /// <summary>
    /// Retorna informações sobre Clientes
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private IClienteAppService _clienteApp;

        /// <summary>
        /// Construtor Default
        /// </summary>
        /// <param name="clienteApp"></param>
        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        /// <summary>
        /// Retorna todos Clientes
        /// </summary>
        /// <returns></returns>
        [Authorize("Bearer")]
        [HttpGet("getall")]
        public IEnumerable<Cliente> GetAll()
        {
            var clientes = _clienteApp.GetAll();
            return clientes;
        }

        /// <summary>
        /// Retorna clientes por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid/{id}")]
        public Cliente GetById(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.GetById(id);
            return cliente;
        }

        /// <summary>
        /// Retorna clientes que possuem Chamados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getidwithorders/{id}")]
        public Cliente GetByIdWithOrders(int id)
        {
            //var cliente = _clienteApp.GetById(id);
            var cliente = _clienteApp.ClienteComPedido(id);
            return cliente;
        }

        /// <summary>
        /// Adiciona um novo cliente
        /// </summary>
        /// <param name="cliente"></param>
        [HttpPost("add")]
        public void Add([FromBody]Cliente cliente)
        {
            _clienteApp.Add(cliente);
        }

        /// <summary>
        /// Atualiza um cliente
        /// </summary>
        /// <param name="cliente"></param>
        [HttpPut("update")]
        public void Update([FromBody]Cliente cliente)
        {
            _clienteApp.Update(cliente);
        }

        /// <summary>
        /// Apaga um cliente
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("delete")]
        public void Delete(int id)
        {
            _clienteApp.Remove(_clienteApp.GetById(id));
        }
    }
}
