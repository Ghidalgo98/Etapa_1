using System;
using System.Collections.Generic;

namespace Capa_Modelos;

public partial class Proveedor
{
    public long IdProveedor { get; set; }

    public string? NombreProveedor { get; set; }

    public int? IdTelefono { get; set; }

    public int? TipoInsumo { get; set; }

    public bool? Estado { get; set; }

    public virtual Telefono? IdTelefonoNavigation { get; set; }

    public virtual PersonaJuridica? PersonaJuridica { get; set; }

    public virtual ICollection<ProveedorProducto> ProveedorProductos { get; set; } = new List<ProveedorProducto>();

    public virtual ICollection<Correo> CorreoIdCorreos { get; set; } = new List<Correo>();
}
