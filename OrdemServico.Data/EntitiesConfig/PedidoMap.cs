using Microsoft.EntityFrameworkCore;
using OrdemServico.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemServico.Data
{
    public class PedidoMap : IEntityMap
    {
        public PedidoMap(ModelBuilder builder)
        {
            builder.Entity<Pedido>().HasOne(c => c.Cliente).WithMany(c => c.Pedido).HasForeignKey(c => c.ClienteId);
        }
    }
}
