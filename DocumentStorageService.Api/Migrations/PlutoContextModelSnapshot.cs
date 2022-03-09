﻿// <auto-generated />
using System;
using DocumentStorageService.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DocumentStorageService.Api.Migrations
{
    [DbContext(typeof(PlutoContext))]
    partial class PlutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DocumentStorageService.Api.Core.Domain.Document", b =>
                {
                    b.Property<int>("doc_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("doc_id"));

                    b.Property<int?>("app_id")
                        .HasColumnType("integer");

                    b.Property<int>("creation_obua_id")
                        .HasColumnType("integer");

                    b.Property<int>("creation_timestamp")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("document_type_id")
                        .HasColumnType("integer");

                    b.Property<string>("file")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("file_size")
                        .HasColumnType("integer");

                    b.Property<int>("file_type")
                        .HasColumnType("integer");

                    b.Property<string>("filename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("last_download_obua_id")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("last_download_timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_upload_obua_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("last_upload_timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("doc_id");

                    b.ToTable("document");
                });

            modelBuilder.Entity("DocumentStorageService.Api.Core.Domain.FileType", b =>
                {
                    b.Property<int>("file_type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("file_type_id"));

                    b.Property<int>("document_id")
                        .HasColumnType("integer");

                    b.Property<string>("file_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("finish_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("file_type_id");

                    b.HasIndex("document_id")
                        .IsUnique();

                    b.ToTable("file_type");
                });

            modelBuilder.Entity("DocumentStorageService.Api.Core.Domain.FileType", b =>
                {
                    b.HasOne("DocumentStorageService.Api.Core.Domain.Document", "document")
                        .WithOne("file_types")
                        .HasForeignKey("DocumentStorageService.Api.Core.Domain.FileType", "document_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("document");
                });

            modelBuilder.Entity("DocumentStorageService.Api.Core.Domain.Document", b =>
                {
                    b.Navigation("file_types")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}