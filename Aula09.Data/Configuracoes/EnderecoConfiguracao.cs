using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class EnderecoConfiguracao : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco", "Elton_Valdez");
            builder.HasKey("IdEndereco");
            builder.Property(f => f.IdEndereco).HasColumnName("IdEndereco");
            builder.Property(f => f.IdCliente).HasColumnName("IdCliente");
            builder.Property(f => f.IdComercio).HasColumnName("IdComercio");
            builder.Property(f => f.Cep).HasColumnName("Cep");
            builder.Property(f => f.Logradouro).HasColumnName("Logradouro");
            builder.Property(f => f.Numero).HasColumnName("Numero");
            builder.Property(f => f.Bairro).HasColumnName("Bairro");
            builder.Property(f => f.Cidade).HasColumnName("Cidade");
            builder.Property(f => f.Estado).HasColumnName("Estado")
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
