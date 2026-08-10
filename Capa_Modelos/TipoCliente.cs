using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class TipoCliente
{
    public int IdTipoCliente { get; set; }

    public string DescripcionTipoCliente { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
