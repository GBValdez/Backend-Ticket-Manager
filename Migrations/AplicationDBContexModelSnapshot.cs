﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using tickets;

#nullable disable

namespace tickets.Migrations
{
    [DbContext(typeof(AplicationDBContex))]
    partial class AplicationDBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RolUser", b =>
                {
                    b.Property<int>("Rolesid")
                        .HasColumnType("integer");

                    b.Property<int>("Usersid")
                        .HasColumnType("integer");

                    b.HasKey("Rolesid", "Usersid");

                    b.HasIndex("Usersid");

                    b.ToTable("RolUser");
                });

            modelBuilder.Entity("tickets.models.Entity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("nit")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("id");

                    b.ToTable("Entity");
                });

            modelBuilder.Entity("tickets.models.EventDate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Eventsid")
                        .HasColumnType("integer");

                    b.Property<int>("eventId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("finalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("initDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("Eventsid");

                    b.ToTable("EventDate");
                });

            modelBuilder.Entity("tickets.models.EventXSection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<int?>("Eventsid")
                        .HasColumnType("integer");

                    b.Property<int>("SectionId")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("Eventsid");

                    b.HasIndex("SectionId");

                    b.ToTable("EventXSection");
                });

            modelBuilder.Entity("tickets.models.Events", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("responsibleId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("responsibleId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("tickets.models.Responsible", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("EntityId");

                    b.ToTable("Responsible");
                });

            modelBuilder.Entity("tickets.models.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("tickets.models.Section", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("tickets.models.Ticket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("EventDateid")
                        .HasColumnType("integer");

                    b.Property<int?>("Sectionid")
                        .HasColumnType("integer");

                    b.Property<int>("idClient")
                        .HasColumnType("integer");

                    b.Property<int>("idEventDate")
                        .HasColumnType("integer");

                    b.Property<int>("idReceiver")
                        .HasColumnType("integer");

                    b.Property<int>("idSection")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("EventDateid");

                    b.HasIndex("Sectionid");

                    b.HasIndex("idClient");

                    b.HasIndex("idReceiver");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("tickets.models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("clientId")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("clientId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RolUser", b =>
                {
                    b.HasOne("tickets.models.Rol", null)
                        .WithMany()
                        .HasForeignKey("Rolesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tickets.models.User", null)
                        .WithMany()
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tickets.models.EventDate", b =>
                {
                    b.HasOne("tickets.models.Events", "Events")
                        .WithMany()
                        .HasForeignKey("Eventsid");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("tickets.models.EventXSection", b =>
                {
                    b.HasOne("tickets.models.Events", "Events")
                        .WithMany()
                        .HasForeignKey("Eventsid");

                    b.HasOne("tickets.models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("tickets.models.Events", b =>
                {
                    b.HasOne("tickets.models.Entity", "Entity")
                        .WithMany()
                        .HasForeignKey("responsibleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("tickets.models.Responsible", b =>
                {
                    b.HasOne("tickets.models.Entity", "Entity")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("tickets.models.Ticket", b =>
                {
                    b.HasOne("tickets.models.EventDate", "EventDate")
                        .WithMany()
                        .HasForeignKey("EventDateid");

                    b.HasOne("tickets.models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("Sectionid");

                    b.HasOne("tickets.models.Entity", "ClientEntity")
                        .WithMany()
                        .HasForeignKey("idClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tickets.models.Entity", "ReceiverEntity")
                        .WithMany()
                        .HasForeignKey("idReceiver")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientEntity");

                    b.Navigation("EventDate");

                    b.Navigation("ReceiverEntity");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("tickets.models.User", b =>
                {
                    b.HasOne("tickets.models.Entity", "Entity")
                        .WithMany()
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });
#pragma warning restore 612, 618
        }
    }
}
