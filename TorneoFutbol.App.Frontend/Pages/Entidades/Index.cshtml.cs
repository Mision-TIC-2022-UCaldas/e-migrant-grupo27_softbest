using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Entidades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEntidades _repoEntidad;
        public IEnumerable <Entidad> entidad {get; set;}
        public IndexModel(IRepositorioEntidades repoEntidad)
        {
            _repoEntidad = repoEntidad;
        }
        public void OnGet()
        {
            entidad = _repoEntidad.GetAllEntidades();
        }
    }
}
