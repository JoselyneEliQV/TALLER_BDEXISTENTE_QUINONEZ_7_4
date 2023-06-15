using System;
using System.Collections.Generic;

namespace TALLER_BDEXISTENTE_QUINONEZ_7_4
{
    public partial class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public int? IdProducto { get; set; }
        public int? IdFactura { get; set; }

        public virtual Factura? IdFacturaNavigation { get; set; }
        public virtual Producto? IdProductoNavigation { get; set; }
    }
}
