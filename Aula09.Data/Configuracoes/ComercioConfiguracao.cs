using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    class ComercioConfiguracao : IEntityTypeConfiguration<Comercio>
    {
        public void Configure(EntityTypeBuilder<Comercio> builder)
        {
            builder.ToTable("Comercio", "Elton_Valdez");
            builder.HasKey("IdComercio");
            builder.Property(f => f.IdComercio).HasColumnName("IdComercio");
            builder.Property(f => f.RazaoSocial).HasColumnName("RazaoSocial");
            builder.Property(f => f.Cnpj).HasColumnName("Cnpj")
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
