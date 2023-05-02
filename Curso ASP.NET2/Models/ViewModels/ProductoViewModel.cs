using System.ComponentModel.DataAnnotations;
namespace Curso_ASP.NET2.Models.ViewModels
{
	public class ProductoViewModel
	{
		[Required]
		[Display(Name = "Nombre Producto")]
		public string Nombre { get; set; }

		[Required]
		[Display(Name = "Id Producto")]
		public int IdProducto { get; set; }

	}
}
