using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaEstoqueWeb.Models;

namespace SistemaEstoqueWeb.Data
{
    public class SistemaEstoqueWebContext : DbContext
    {
        public SistemaEstoqueWebContext (DbContextOptions<SistemaEstoqueWebContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaEstoqueWeb.Models.Produto> Produto { get; set; }
        public DbSet<UsuarioCadastro> Usuario { get; set; }
    }
}
