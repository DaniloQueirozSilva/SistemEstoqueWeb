using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEstoqueWeb.Migrations
{
    public partial class FinalBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produto",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    dataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_UsuarioID",
                table: "Produto",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_UsuarioID",
                table: "Produto",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_UsuarioID",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Produto_UsuarioID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Produto");
        }
    }
}
