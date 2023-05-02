using System;
using System.Collections.Generic;

namespace Curso_ASP.NET2.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public virtual ICollection<ListaProducto> ListaProductos { get; set; } = new List<ListaProducto>();
}
