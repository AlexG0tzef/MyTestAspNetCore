﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTestAspNetCore.Data;

#nullable disable

namespace MyTestAspNetCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220413134328_UpdateForms")]
    partial class UpdateForms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyTestAspNetCore.Models.CategoryM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyTestAspNetCore.Models.FormsM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Cod14")
                        .HasColumnType("int");

                    b.Property<int?>("Cod2")
                        .HasColumnType("int");

                    b.Property<int?>("CodOKPO10")
                        .HasColumnType("int");

                    b.Property<int?>("CodOKPO15")
                        .HasColumnType("int");

                    b.Property<int?>("CodPer20")
                        .HasColumnType("int");

                    b.Property<int?>("CodPos19")
                        .HasColumnType("int");

                    b.Property<int>("CorNum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date11")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date18")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date3")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Kol8")
                        .HasColumnType("int");

                    b.Property<int?>("NSS13")
                        .HasColumnType("int");

                    b.Property<string>("Name21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number17")
                        .HasColumnType("int");

                    b.Property<int?>("Number23")
                        .HasColumnType("int");

                    b.Property<int?>("Number7")
                        .HasColumnType("int");

                    b.Property<int?>("NumberPP1")
                        .HasColumnType("int");

                    b.Property<int?>("NumberPassport4")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Radionuclid6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SumActiv9")
                        .HasColumnType("int");

                    b.Property<string>("Type22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type5")
                        .HasColumnType("int");

                    b.Property<string>("Vid16")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("FormsM");
                });

            modelBuilder.Entity("MyTestAspNetCore.Models.OrganizationM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdrYr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaksOrg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("INN")
                        .HasColumnType("int");

                    b.Property<int>("KPP")
                        .HasColumnType("int");

                    b.Property<string>("MailOrg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OKFS")
                        .HasColumnType("int");

                    b.Property<int>("OKOGY")
                        .HasColumnType("int");

                    b.Property<int>("OKOPF")
                        .HasColumnType("int");

                    b.Property<int>("OKPO")
                        .HasColumnType("int");

                    b.Property<int>("OKTMO")
                        .HasColumnType("int");

                    b.Property<int>("OKVED")
                        .HasColumnType("int");

                    b.Property<string>("OrganYprav")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegNumber")
                        .HasColumnType("int");

                    b.Property<string>("ShortYrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectRF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("MyTestAspNetCore.Models.FormsM", b =>
                {
                    b.HasOne("MyTestAspNetCore.Models.OrganizationM", "Organization")
                        .WithMany("Form")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("MyTestAspNetCore.Models.OrganizationM", b =>
                {
                    b.Navigation("Form");
                });
#pragma warning restore 612, 618
        }
    }
}
