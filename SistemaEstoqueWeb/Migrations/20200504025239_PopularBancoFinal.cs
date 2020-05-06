using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEstoqueWeb.Migrations
{
    public partial class PopularBancoFinal : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Davi Queiroz', 'daviQueiroz@gmail.com', '24/11/1994')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Edson Carlos', 'EdsonCarlos@gmail.com', '14/01/1972')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Solange Correia', 'SolangeCorreia@gmail.com', '08/06/1973')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Thalita Lanhellas', 'ThalitaLanhellas@gmail.com', '11/10/2001')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Luiz Bezerra', 'LuizBezerra@gmail.com', '27/06/1993')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Levi Silva', 'LeviSilva@gmail.com', '08/04/1979')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Juresma Cardoso', 'jrCardoso@gmail.com', '22/04/1959')");
            mb.Sql("INSERT INTO Usuario(Nome,Email,dataNascimento) VALUES('Bolsonaro Messias', 'TaOK@gmail.com', '11/04/1927')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
