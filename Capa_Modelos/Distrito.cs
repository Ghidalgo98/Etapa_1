using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Distrito
{
    public int IdDistrito { get; set; }

    public string IdPersonaDistrito { get; set; } = null!;

    public string DescripcionDistrito { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();
}
