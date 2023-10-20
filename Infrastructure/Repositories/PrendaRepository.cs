using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class PrendaRepository : GenericRepository<Prenda>, IPrenda
    {
        public PrendaRepository(TiendaContext context) : base(context)
        {
        }
    }
}