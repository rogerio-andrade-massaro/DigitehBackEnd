using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoAustralia.Domain
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        IRepositoryCliente clienteRepository;
        public ServiceCliente(IRepositoryCliente clienteRepository) : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public Cliente ClienteComPedido(int clienteId)
        {
            return this.clienteRepository.ClienteComPedido(clienteId);
        }

        public void teste()
        {
            var teste = this.GetAll().ToList().Where(x => x.Nome.Contains("rogerio"));
            
        }
    }
}
