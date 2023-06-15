using System;
using System.Collections.Generic;

namespace TALLER_BDEXISTENTE_QUINONEZ_7_4
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Dirección { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Correo { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
