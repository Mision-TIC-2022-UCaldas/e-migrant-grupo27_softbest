using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioNovedades
    {
        IEnumerable<Novedad> GetAllNovedad();
        Novedad AddNovedad(Novedad novedades);
        Novedad UpdateNovedad(Novedad novedades);
        void DeleteNovedad(int novedades);
        Novedad GetNovedad(int novedades);
        public IEnumerable<Novedad> GetNovedadNombre(string Descripcion);

    }
}