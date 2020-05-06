using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstoqueWeb.Models
{
    public class Produto

    {
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public string NumeroSerie { get; set; }
        public int Quantidade { get; set; }
        public double Preço { get; set; }
        public  DateTime DataCadastro { get; set; }
        public UsuarioCadastro UsuarioId { get; set; }

        public Produto()
        {
        }

        public Produto(int produtoID, string nomeProduto, string numeroSerie, int quantidade, double preço, UsuarioCadastro usuarioId)
        {
            ProdutoID = produtoID;
            NomeProduto = nomeProduto;
            NumeroSerie = numeroSerie;
            Quantidade = quantidade;
            Preço = preço;
            UsuarioId = usuarioId;
        }

        public double TotalValorProduto() 
        {
            return Preço * Quantidade;
        }



    }
}
