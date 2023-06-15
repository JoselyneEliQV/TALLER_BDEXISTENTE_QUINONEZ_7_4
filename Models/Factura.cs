using System;
using System.Collections.Generic;

namespace TALLER_BDEXISTENTE_QUINONEZ_7_4
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
            Pagos = new HashSet<Pago>();
        }

        public int IdFactura { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string? EstadoPagado { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
