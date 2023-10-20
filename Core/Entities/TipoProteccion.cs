using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoProteccion : BaseEntity
    {
        public string Descripcion { get; set; }
        public ICollection<TipoProteccion> TipoProtecciones { get; set; }
    }
}