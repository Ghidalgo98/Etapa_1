using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Telefono
{
    public int IdTelefono { get; set; }

    public long IdPersona { get; set; }

    public string? DescripcionTelefono { get; set; }

    public bool? Estado { get; set; }

    public virtual PersonaFisica IdPersona1 { get; set; } = null!;

    public virtual PersonaJuridica IdPersonaNavigation { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
