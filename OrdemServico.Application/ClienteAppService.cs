using ProjetoAustralia.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private IServiceCliente serviceCliente;
        public ClienteAppService(IServiceCliente serviceCliente) : base(serviceCliente)
        {
            this.serviceCliente = serviceCliente;
        }

        public Cliente ClienteComPedido(int clienteId)
        {
            return serviceCliente.ClienteComPedido(clienteId);
        }
    }
}
