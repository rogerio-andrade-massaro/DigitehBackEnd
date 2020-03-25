using OrdemServico.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemServico.Application
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        Cliente ClienteComPedido(int clienteId);
    }
}
