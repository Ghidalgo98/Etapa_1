using System;
using System.Collections.Generic;

namespace SistemaBase.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string DescripcionDepartamento { get; set; } = null!;

    public bool Estado { get; set; }
}
