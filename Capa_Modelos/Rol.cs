using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Rol
{
    public int IdRol { get; set; }

    public string DescripciónRol { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<EmpleadoRol> EmpleadoRols { get; set; } = new List<EmpleadoRol>();
}
