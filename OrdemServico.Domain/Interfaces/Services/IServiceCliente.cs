using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Domain
{
    public interface IServiceCliente : IServiceBase<Cliente>
    {
        Cliente ClienteComPedido(int clienteId);
    }
}
