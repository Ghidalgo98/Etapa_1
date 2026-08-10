using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class PersonaFisicaCorreo
{
    public int CorreoIdCorreo { get; set; }

    public long PersonaFisicaId { get; set; }

    public virtual Correo CorreoIdCorreoNavigation { get; set; } = null!;

    public virtual PersonaFisica PersonaFisica { get; set; } = null!;
}
