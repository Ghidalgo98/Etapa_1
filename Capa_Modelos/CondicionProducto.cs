using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class CondicionProducto
{
    public int IdCondicion { get; set; }

    public string? DescripcionCondicion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
