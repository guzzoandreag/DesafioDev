using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioDev.Infrastructure.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    for_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    for_nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    for_cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.for_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    pro_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pro_situacao = table.Column<bool>(type: "bit", nullable: false),
                    pro_datafabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pro_datavalidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    for_codigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.pro_codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
