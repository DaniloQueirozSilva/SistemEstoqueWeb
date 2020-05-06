using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEstoqueWeb.Migrations
{
    public partial class PularBancoProduto : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Notebook', '899-001', 10, 3200.00, '04/05/2020', 1)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Desktop', '899-002', 6, 2450.00, '04/05/2020', 1)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Smartphone Maple', '899-003', 25, 7000.00, '04/05/2020', 1)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Fone de Ouvido', '899-004', 10, 100.00, '04/05/2020', 1)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Geladeira', '511-001', 15,5000.99, '04/05/2020', 3)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Fogão', '511-002', 10, 2200.00, '04/05/2020', 3)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Micro-ondas', '511-004', 5, 1200.00, '04/05/2020', 3)");
            mb.Sql("INSERT INTO Produto(NomeProduto,NumeroSerie,Quantidade,Preço,DataCadastro,UsuarioID) VALUES('Panela Eletrica', '511-005', 8, 2500.00, '04/05/2020', 3");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
