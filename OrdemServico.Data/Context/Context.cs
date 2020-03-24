using Microsoft.EntityFrameworkCore;
using ProjetoAustralia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjetoAustralia.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = true;
        }

        private void RegisterMaps(ModelBuilder builder)
        {
            var maps = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrWhiteSpace(type.Namespace)
                && typeof(IEntityMap).IsAssignableFrom(type) && type.IsClass).ToList();

            //var maps = typeof(a type in that assembly).GetTypeInfo().Assembly.GetTypes()
            //    .Where(type => !string.IsNullOrWhiteSpace(type.Namespace)
            //        && typeof(IEntityMap).IsAssignableFrom(type) && type.IsClass).ToList();

            foreach (var item in maps)
                if (item.Name != "IEntityMap")
                {
                    Activator.CreateInstance(item, BindingFlags.Public |
                    BindingFlags.Instance, null, new object[] { builder }, null);
                }
        }
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RegisterMaps(modelBuilder);
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Pedido>().HasOne(c => c.Cliente).WithMany(c => c.Pedido).HasForeignKey(c => c.ClienteId);

        }
    }
}
