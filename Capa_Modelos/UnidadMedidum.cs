using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class UnidadMedidum
{
    public int IdUnidad { get; set; }

    public string? DescripcionUnidad { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
