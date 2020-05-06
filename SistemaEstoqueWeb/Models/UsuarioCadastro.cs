 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SistemaEstoqueWeb.Models
{
    public class UsuarioCadastro
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime dataNascimento { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();


        public UsuarioCadastro() { }

        public UsuarioCadastro(int usuarioID, string nome, string email, DateTime dataNascimento)
        {
            this.UsuarioID = usuarioID;
            Nome = nome;
            Email = email;
            this.dataNascimento = dataNascimento;
        }

        public void AddProduto (Produto prod){

             Produtos.Add(prod);
        
        }

        public void RemoveProduto(Produto prod)
        {

            Produtos.Remove(prod);

        }
                

        public double SomaEstoque()
        {
            return Produtos.Sum(prod => prod.Preço * prod.Quantidade);
        }
    }
}
