﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notebook.API.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Notebook.API.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231031124002_InitialPersistedGrantDbMigration")]
    partial class InitialPersistedGrantDbMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Notebook.API.Models.Domain.Notes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NoteTag")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoteText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoteTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Note");
                });
#pragma warning restore 612, 618
        }
    }
}
