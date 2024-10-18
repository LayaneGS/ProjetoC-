using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoC_.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Produto",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Adcionado",
                table: "Produto",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Produto",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Data_Adcionado",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Produto");

            migrationBuilder.AddColumn<bool>(
                name: "Situacao",
                table: "Produto",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
