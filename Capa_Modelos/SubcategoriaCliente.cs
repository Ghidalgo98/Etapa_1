using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class SubcategoriaCliente
{
    public int IdCategoriaCliente { get; set; }

    public string DescripcionCategoriaCliente { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
