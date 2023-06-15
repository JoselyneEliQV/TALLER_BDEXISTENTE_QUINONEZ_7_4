using System;
using System.Collections.Generic;

namespace TALLER_BDEXISTENTE_QUINONEZ_7_4
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal? PrecioUnitario { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
