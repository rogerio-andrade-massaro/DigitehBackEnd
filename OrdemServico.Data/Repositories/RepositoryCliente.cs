using Microsoft.EntityFrameworkCore;
using OrdemServico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdemServico.Data
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(Context Db)
        {
            this.Db = Db;
        }
        public Cliente ClienteComPedido(int clienteId)
        {
            return Db.Cliente.Include(p => p.Pedido).Where(c => c.ClienteId == clienteId).First();
        }
    }
}
