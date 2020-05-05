using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente", "Elton_Valdez");
            builder.HasKey("IdCliente");
            builder.Property(f => f.IdCliente).HasColumnName("IdCliente");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Cpf).HasColumnName("Cpf");
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
            builder.Property(f => f.Sexo).HasColumnName("Sexo")
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
