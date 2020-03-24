using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Domain
{
    public interface IRepositoryCliente : IRepositoryBase<Cliente>
    {
        Cliente ClienteComPedido(int clienteId);
    }
}
