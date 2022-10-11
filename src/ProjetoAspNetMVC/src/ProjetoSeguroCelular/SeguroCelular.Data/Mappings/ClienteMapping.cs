using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeguroCelular.Domain.Entities;

namespace SeguroCelular.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired();

            builder.Property(c => c.Sobrenome)
                .IsRequired();

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(c => c.DataNascimento)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco, e =>
            {
                e.Property(c => c.Rua)
                .HasColumnName("Rua")
                .HasColumnType("string");

                e.Property(c => c.Numero)
                .HasColumnName("Numero")
                .HasColumnType("string");

                e.Property(c => c.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("string");

                e.Property(c => c.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("string");

                e.Property(c => c.Estado)
                .HasColumnName("Estado")
                .HasColumnType("int");

                e.Property(c => c.Pais)
                .HasColumnName("Pais")
                .HasColumnType("string");
            });

            builder.ToTable("Clientes");
        }
    }
}
