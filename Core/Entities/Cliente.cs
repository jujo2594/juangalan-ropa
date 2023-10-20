using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; } //Unica
        public string Nombre { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersonas { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}