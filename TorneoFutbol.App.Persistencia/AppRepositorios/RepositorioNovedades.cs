using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioNovedades : IRepositorioNovedades
    {
        private readonly AppContext _appContext = new AppContext();
        public Novedad AddNovedad(Novedad novedades)
        {
            var NovedadAdicionado = _appContext.Novedades.Add(novedades);
            _appContext.SaveChanges();
            return NovedadAdicionado.Entity;
        }

        public void DeleteNovedad(int idNovedades)
        {
            var novedadEncontrado=_appContext.Novedades.FirstOrDefault(p=>p.Id==idNovedades);
            if(novedadEncontrado==null)
                return;
            _appContext.Novedades.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Novedad> GetAllNovedad()
        {
            return _appContext.Novedades;
        }

        public Novedad GetNovedad(int idNovedad)
        {
            return _appContext.Novedades.FirstOrDefault(p=>p.Id==idNovedad);
        }

        public Novedad UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrado=_appContext.Novedades.FirstOrDefault(p=>p.Id==novedad.Id);
            if(novedadEncontrado!=null)
            {
                novedadEncontrado.Fecha_Novedad = novedad.Fecha_Novedad;
                
                novedadEncontrado.Dias_Activo = novedad.Dias_Activo;
               
                novedadEncontrado.Descripcion = novedad.Descripcion;

                
               
                
                _appContext.SaveChanges();
            }
            return novedadEncontrado;
        }

         public IEnumerable<Novedad> GetNovedadNombre(string Descripcion)
        {
            return _appContext.Novedades
                   .Where(P => P.Descripcion.Contains(Descripcion));
        }
    }
}