using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class UsuarioCorreo
{
    public int CorreoIdCorreo { get; set; }

    public long UsuarioPersonaFisicaId { get; set; }

    public virtual Correo CorreoIdCorreoNavigation { get; set; } = null!;

    public virtual Usuario UsuarioPersonaFisica { get; set; } = null!;
}
