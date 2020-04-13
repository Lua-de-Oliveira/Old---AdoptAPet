﻿// <auto-generated />
using System;
using AdoptAPet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdoptAPet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200413013906_Shelter")]
    partial class Shelter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdoptAPet.Models.Animal", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<string>("DateArrival");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<int?>("ShelterID");

                    b.Property<string>("Size");

                    b.HasKey("AnimalID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ShelterID");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("AdoptAPet.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AdoptAPet.Models.Shelter", b =>
                {
                    b.Property<int>("ShelterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("CpfOrCnpj");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<string>("Phone");

                    b.Property<string>("SocialMedia");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.HasKey("ShelterID");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("AdoptAPet.Models.Animal", b =>
                {
                    b.HasOne("AdoptAPet.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("AdoptAPet.Models.Shelter", "Shelter")
                        .WithMany()
                        .HasForeignKey("ShelterID");
                });
#pragma warning restore 612, 618
        }
    }
}