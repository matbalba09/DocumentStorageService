using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DocumentStorageService.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "document",
                columns: table => new
                {
                    doc_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    app_id = table.Column<int>(type: "integer", nullable: true),
                    creation_obua_id = table.Column<int>(type: "integer", nullable: false),
                    creation_timestamp = table.Column<int>(type: "integer", nullable: false),
                    last_upload_obua_id = table.Column<int>(type: "integer", nullable: false),
                    last_upload_timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_download_obua_id = table.Column<int>(type: "integer", nullable: true),
                    last_download_timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    document_type_id = table.Column<int>(type: "integer", nullable: false),
                    file_size = table.Column<int>(type: "integer", nullable: false),
                    file_type = table.Column<int>(type: "integer", nullable: false),
                    filename = table.Column<string>(type: "text", nullable: false),
                    file = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document", x => x.doc_id);
                });

            migrationBuilder.CreateTable(
                name: "file_type",
                columns: table => new
                {
                    file_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    file_type = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    finish_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    document_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_type", x => x.file_type_id);
                    table.ForeignKey(
                        name: "FK_file_type_document_document_id",
                        column: x => x.document_id,
                        principalTable: "document",
                        principalColumn: "doc_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_file_type_document_id",
                table: "file_type",
                column: "document_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "file_type");

            migrationBuilder.DropTable(
                name: "document");
        }
    }
}
