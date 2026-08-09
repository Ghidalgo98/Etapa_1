using System;
using System.Collections.Generic;

namespace SistemaBase.Models;

public partial class TipoPersonaFisica
{
    public int IdTipoPersona { get; set; }

    public string DescripcionTipoPersona { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<PersonaFisica> PersonaFisicas { get; set; } = new List<PersonaFisica>();
}
