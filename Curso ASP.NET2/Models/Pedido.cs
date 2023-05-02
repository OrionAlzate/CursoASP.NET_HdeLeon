using System;
using System.Collections.Generic;

namespace Curso_ASP.NET2.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int IdCliente { get; set; }

    public int IdLista { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
