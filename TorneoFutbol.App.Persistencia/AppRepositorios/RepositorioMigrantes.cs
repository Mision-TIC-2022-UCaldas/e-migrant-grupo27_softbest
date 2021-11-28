using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioMigrantes : IRepositorioMigrantes
    {
        private readonly AppContext _appContext = new AppContext();
        
        Migrante IRepositorioMigrantes.AddMigrante(Migrante migrante)
        {
            var MigranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return MigranteAdicionado.Entity;
        }

        void IRepositorioMigrantes.DeleteMigrante(int idMigrante)
        {
            var migranteEncontrado=_appContext.Migrantes.FirstOrDefault(m=>m.Id==idMigrante);
            if(migranteEncontrado==null)
                return;
            _appContext.Migrantes.Remove(migranteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Migrante> IRepositorioMigrantes.GetAllMigrante()
        {
            return _appContext.Migrantes;
        }

        Migrante IRepositorioMigrantes.GetMigrante(int IdMigrante)
        {
           var migrante = _appContext.Migrantes
                .Where(p => p.Id == IdMigrante)
                .Include(p => p.Grupo)
                .FirstOrDefault();
            return migrante;
            
        }

        Migrante IRepositorioMigrantes.UpdateMigrante(Migrante migrante)
        {
            var migranteEncontrado=_appContext.Migrantes.FirstOrDefault(m=>m.Id==migrante.Id);
            if(migranteEncontrado!=null)
            {
                migranteEncontrado.Nombre = migrante.Nombre;
                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }

        Grupo IRepositorioMigrantes.AsignarGrupo(int IdMigrante, int IdGrupo)
        { var MigranteEncontrado = _appContext.Migrantes.Find(IdMigrante);
            if (MigranteEncontrado != null)
            { var grupoEncontrado = _appContext.Grupos.Find(IdGrupo);
            if (grupoEncontrado != null)
            { MigranteEncontrado.Grupo = grupoEncontrado;
            _appContext.SaveChanges();
            }
            return grupoEncontrado;
            }
            return null;
        }
        public IEnumerable<Migrante> GetMigranteCedula(string cedula)
        {
            return _appContext.Migrantes
                   .Where(P => P.Numero_Identificacion.Contains(cedula));
        }
    }
}