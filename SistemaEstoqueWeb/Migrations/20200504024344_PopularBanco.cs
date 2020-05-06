using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEstoqueWeb.Migrations
{
    public partial class PopularBanco : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Danilo Queiroz', 'danilosQueiroz@gmail.com', '13/01/2000')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Danilo Queiroz', 'danilosQueiroz@gmail.com', '13/01/2000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
