using System;
using System.Collections.Generic;

namespace TALLER_BDEXISTENTE_QUINONEZ_7_4
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public decimal? MontoPagado { get; set; }
        public string? MetodoPago { get; set; }
        public int? IdFactura { get; set; }

        public virtual Factura? IdFacturaNavigation { get; set; }
    }
}
