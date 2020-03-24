using ProjetoAustralia.Domain;
using StaticDotNet.EntityFrameworkCore.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAustralia.Data
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //HasKey(c => c.ClienteId);

            //Property(c => c.Nome)
            //    .IsRequired()
            //    .HasMaxLength(150);

            //Property(c => c.Cpf)
            //    .IsRequired()
            //    .HasMaxLength(11);


        }

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            throw new NotImplementedException();
        }

        //public override void Configure(EntityTypeBuilder<Cliente> builder)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
//https://stackoverflow.com/questions/26957519/ef-core-mapping-entitytypeconfiguration
//https://www.codeproject.com/tips/1119108/organizing-fluent-configurations-into-separate-cla
//https://github.com/aspnet/EntityFrameworkCore/issues/2805