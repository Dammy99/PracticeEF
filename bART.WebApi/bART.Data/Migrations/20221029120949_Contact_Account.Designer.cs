﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bART.Data.Context;

#nullable disable

namespace bART.Data.Migrations
{
    [DbContext(typeof(BartContext))]
    [Migration("20221029120949_Contact_Account")]
    partial class Contact_Account
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("bART.Data.Entities.Account", b =>
                {
                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IncidentName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountName");

                    b.HasIndex("IncidentName");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("bART.Data.Entities.Contact", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("AccountName");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("bART.Data.Entities.Incident", b =>
                {
                    b.Property<string>("IncidentName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentName");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("bART.Data.Entities.Account", b =>
                {
                    b.HasOne("bART.Data.Entities.Incident", "Incident")
                        .WithMany("Accounts")
                        .HasForeignKey("IncidentName");

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("bART.Data.Entities.Contact", b =>
                {
                    b.HasOne("bART.Data.Entities.Account", "Account")
                        .WithMany("Contacts")
                        .HasForeignKey("AccountName");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("bART.Data.Entities.Account", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("bART.Data.Entities.Incident", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
