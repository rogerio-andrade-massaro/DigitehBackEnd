using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemServico.Domain
{
    public interface IRepositoryCliente : IRepositoryBase<Cliente>
    {
        Cliente ClienteComPedido(int clienteId);
    }
}
