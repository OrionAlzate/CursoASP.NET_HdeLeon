using Curso_ASP.NET2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Curso_ASP.NET2.Controllers
{
    public class ClienteController : Controller
    {

        private readonly tiendaASP_NETContext _context;

        public ClienteController(tiendaASP_NETContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View( await _context.Clientes.ToListAsync());
        }
    }
}
