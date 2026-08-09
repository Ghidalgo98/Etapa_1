using System;
using System.Collections.Generic;

namespace SistemaBase.Models;

public partial class Canton
{
    public int IdCantón { get; set; }

    public int? IdPersonaCanton { get; set; }

    public string? DescripciónCanton { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();
}
