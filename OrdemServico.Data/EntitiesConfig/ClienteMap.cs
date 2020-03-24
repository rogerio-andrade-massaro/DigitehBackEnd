using Microsoft.EntityFrameworkCore;
using ProjetoAustralia.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAustralia.Data
{
    public class ClienteMap : IEntityMap
    {
        public ClienteMap(ModelBuilder builder)
        {
            builder.Entity<Cliente>(b =>
            {
                b.HasKey(e => e.ClienteId);
                b.Property(e => e.Nome).HasMaxLength(50).IsRequired();
                b.HasMany(e => e.Pedido);
               
                //var person = _context.Person.Include(p => p.Hats).Where(p => p.id == id).ToList();
            });
        }
    }
}
