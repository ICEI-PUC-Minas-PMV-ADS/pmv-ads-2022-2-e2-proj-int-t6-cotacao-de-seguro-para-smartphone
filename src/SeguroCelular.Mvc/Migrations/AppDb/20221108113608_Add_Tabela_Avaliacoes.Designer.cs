﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeguroCelular.Mvc.Models.Data;

namespace SeguroCelular.Mvc.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221108113608_Add_Tabela_Avaliacoes")]
    partial class Add_Tabela_Avaliacoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeguroCelular.Mvc.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CotacaoSeguroId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoSeguroId");

                    b.HasIndex("UserId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.CotacaoSeguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModeloCelular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorCotacao")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CotacaoSeguro");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.Avaliacao", b =>
                {
                    b.HasOne("SeguroCelular.Mvc.Models.CotacaoSeguro", "CotacaoSeguro")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("CotacaoSeguroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeguroCelular.Mvc.Models.User", "User")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CotacaoSeguro");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.CotacaoSeguro", b =>
                {
                    b.HasOne("SeguroCelular.Mvc.Models.User", "User")
                        .WithMany("Cotacoes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.CotacaoSeguro", b =>
                {
                    b.Navigation("Avaliacoes");
                });

            modelBuilder.Entity("SeguroCelular.Mvc.Models.User", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Cotacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
