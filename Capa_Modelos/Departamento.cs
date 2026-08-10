using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string DescripcionDepartamento { get; set; } = null!;

    public bool Estado { get; set; }
}
