using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaEstoqueWeb.Data;


namespace SistemaEstoqueWeb.Controllers
{
    public class UsuariosCadastroController : Controller
    {
        private readonly SistemaEstoqueWebContext _context;

        public UsuariosCadastroController(SistemaEstoqueWebContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Usuario.ToList());
        }
    }
}