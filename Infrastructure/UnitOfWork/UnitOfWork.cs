using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TiendaContext _context;
        private ICargo _cargos;
        private ICliente _clientes;
        private IColor _colores;
        private IDepartamento _departamentos;
        private IDetalleOrden _detalleOrdenes;
        private IDetalleVenta _detalleVentas;
        private IEmpleado _empleados;
        private IEmpresa _empresas;
        private IEstado _estados;
        private IFormaPago _formaPagos;
        private IGenero _generos;
        private IInsumo _insumos;
        private IInventario _inventarios;
        private IMunicipio _municipios;
        private IOrden _ordenes;
        private IPais _paises;
        private IPrenda _prendas;
        private IProveedor _proveedores;
        private ITalla _tallas;
        private ITipoEstado _tipoEstados;
        private ITipoPersona _tipoPersonas;
        private ITipoProteccion _tipoProtecciones;
        private IVenta _ventas;

        public UnitOfWork(TiendaContext context)
        {
            _context = context;
        }

        public ICargo Cargos
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _cargos;
            }
        }

        public ICliente Clientes
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _clientes;
            }
        }
        public IColor Colores 
        {
            get
            {
                if (_colores == null)
                {
                    _colores = new ColorRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _colores;
            }
        }

        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _departamentos;
            }
        }

        public IDetalleOrden DetalleOrdenes
        {
            get
            {
                if (_detalleOrdenes == null)
                {
                    _detalleOrdenes = new DetalleOrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _detalleOrdenes;
            }
        }
        public IDetalleVenta DetalleVentas
        {
            get
            {
                if (_detalleVentas == null)
                {
                    _detalleVentas = new DetalleVentaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _detalleVentas;
            }
        }
        public IEmpleado Empleados
        {
            get
            {
                if (_empleados == null)
                {
                    _empleados = new EmpleadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _empleados;
            }
        }
        public IEmpresa Empresas
        {
            get
            {
                if (_empresas == null)
                {
                    _empresas = new EmpresaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _empresas;
            }
        }
        public IEstado Estados
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _estados;
            }
        }
        public IFormaPago FormaPagos
        {
            get
            {
                if (_formaPagos == null)
                {
                    _formaPagos = new FormaPagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _formaPagos;
            }
        }
        public IGenero Generos
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _generos;
            }
        }
        public IInsumo Insumos
        {
            get
            {
                if (_insumos == null)
                {
                    _insumos = new InsumoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _insumos;
            }
        }
        public IInventario Inventarios
        {
            get
            {
                if (_inventarios == null)
                {
                    _inventarios = new InventarioRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _inventarios;
            }
        }
        public IMunicipio Municipios
        {
            get
            {
                if (_municipios == null)
                {
                    _municipios = new MunicipioRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _municipios;
            }
        }
        public IOrden Ordenes
        {
            get
            {
                if (_ordenes == null)
                {
                    _ordenes = new OrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ordenes;
            }
        }
        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _paises;
            }
        }
        public IPrenda Prendas
        {
            get
            {
                if (_prendas == null)
                {
                    _prendas = new PrendaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _prendas;
            }
        }
        public IProveedor Proveedores
        {
            get
            {
                if (_proveedores == null)
                {
                    _proveedores = new ProveedorRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _proveedores;
            }
        }
        public ITalla Tallas
        {
            get
            {
                if (_tallas == null)
                {
                    _tallas = new TallaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tallas;
            }
        }
        public ITipoEstado TipoEstados
        {
            get
            {
                if (_tipoEstados == null)
                {
                    _tipoEstados = new TipoEstadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoEstados;
            }
        }
        public ITipoPersona TipoPersonas
        {
            get
            {
                if (_tipoPersonas == null)
                {
                    _tipoPersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoPersonas;
            }
        }
        public ITipoProteccion TipoProtecciones
        {
            get
            {
                if (_tipoProtecciones == null)
                {
                    _tipoProtecciones = new TipoProteccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoProtecciones;
            }
        }
        public IVenta Ventas
        {
            get
            {
                if (_ventas == null)
                {
                    _ventas = new VentaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ventas;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}