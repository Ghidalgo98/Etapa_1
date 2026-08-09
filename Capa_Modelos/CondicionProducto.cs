using System;
using System.Collections.Generic;

namespace SistemaBase.Models;

public partial class CondicionProducto
{
    public int IdCondicion { get; set; }

    public string? DescripcionCondicion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
