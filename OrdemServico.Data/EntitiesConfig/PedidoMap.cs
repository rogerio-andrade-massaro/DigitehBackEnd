using Microsoft.EntityFrameworkCore;
using ProjetoAustralia.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Data
{
    public class PedidoMap : IEntityMap
    {
        public PedidoMap(ModelBuilder builder)
        {
            builder.Entity<Pedido>().HasOne(c => c.Cliente).WithMany(c => c.Pedido).HasForeignKey(c => c.ClienteId);
        }
    }
}
