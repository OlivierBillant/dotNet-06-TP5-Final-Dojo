// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TpDojo.Dal;

#nullable disable

namespace TpDojo.Dal.Migrations
{
    [DbContext(typeof(TpDojoContext))]
    [Migration("20220831094618_ArtMartiaux")]
    partial class ArtMartiaux
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TpDojo.Dal.Entities.Arme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Degats")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arme");
                });

            modelBuilder.Entity("TpDojo.Dal.Entities.ArtMartial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SamouraiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SamouraiId");

                    b.ToTable("ArtMartial");
                });

            modelBuilder.Entity("TpDojo.Dal.Entities.Samourai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArmeId")
                        .HasColumnType("int");

                    b.Property<int>("Force")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArmeId");

                    b.ToTable("Samourai");
                });

            modelBuilder.Entity("TpDojo.Dal.Entities.ArtMartial", b =>
                {
                    b.HasOne("TpDojo.Dal.Entities.Samourai", null)
                        .WithMany("ArtMartiaux")
                        .HasForeignKey("SamouraiId");
                });

            modelBuilder.Entity("TpDojo.Dal.Entities.Samourai", b =>
                {
                    b.HasOne("TpDojo.Dal.Entities.Arme", "Arme")
                        .WithMany()
                        .HasForeignKey("ArmeId");

                    b.Navigation("Arme");
                });

            modelBuilder.Entity("TpDojo.Dal.Entities.Samourai", b =>
                {
                    b.Navigation("ArtMartiaux");
                });
#pragma warning restore 612, 618
        }
    }
}
