using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DetalleOrdenDto
    {
        public int Id { get; set; }
        public int IdOrdenFk { get; set; }
        public int IdPrendaFk { get; set; }
        public int IdColorFk { get; set; }
        public int IdEstadoFk { get; set; }
        public int CantidadProducir { get; set; }
        public int CantidadProducida { get; set; }
    }
}