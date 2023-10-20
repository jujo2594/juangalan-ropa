using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        public int IdVentaFk { get; set; }
        public Venta Ventas { get; set; }
        public int IdProductoFk { get; set; }
        public Inventario Inventarios { get; set; } //Se relaciona mediante IdProductoFk
        public int IdTallaFk { get; set; }
        public Talla Tallas { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
    }
}