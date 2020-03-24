using ProjetoAustralia.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Application
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        Cliente ClienteComPedido(int clienteId);
    }
}
