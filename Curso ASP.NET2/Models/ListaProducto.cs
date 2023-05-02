using System;
using System.Collections.Generic;

namespace Curso_ASP.NET2.Models;

public partial class ListaProducto
{
    public int IdLista { get; set; }

    public int IdProducto { get; set; }

    public int CantidadProducto { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
