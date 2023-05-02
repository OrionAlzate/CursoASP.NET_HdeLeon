using Curso_ASP.NET2.Models;
using Curso_ASP.NET2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Curso_ASP.NET2.Controllers
{
	public class ProductoController : Controller
	{

		private readonly tiendaASP_NETContext _context;

		public ProductoController(tiendaASP_NETContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var producto = _context.Productos.Include(b => b.ListaProductos);
			return View(await producto.ToListAsync());
		}

		public IActionResult Create()
		{
			ViewData["Productos"] = new SelectList(_context.Productos, "IdProducto", "IdProducto");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task <IActionResult> Create(ProductoViewModel model)
		{
			if (ModelState.IsValid)
			{
				var producto = new Producto() 
				{
					IdProducto = model.IdProducto,
					NombreProducto = model.Nombre
				};
				_context.Add(producto);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			ViewData["Productos"] = new SelectList(_context.Productos, "IdProducto", "IdProducto", model.IdProducto);
			return View(model);
		}
	}
}
