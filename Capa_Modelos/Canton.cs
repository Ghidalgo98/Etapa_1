using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Canton
{
    public int IdCantón { get; set; }

    public int? IdPersonaCanton { get; set; }

    public string? DescripciónCanton { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();
}
