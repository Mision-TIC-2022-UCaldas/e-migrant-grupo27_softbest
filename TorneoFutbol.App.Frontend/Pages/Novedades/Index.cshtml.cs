using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Novedades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedades _repoNovedad;
        public IEnumerable <Novedad> novedad {get; set;}
        public string gActual{get; set;}
        public IndexModel(IRepositorioNovedades repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }
        public void OnGet(string g)
        {
            if (string.IsNullOrEmpty(g))
            {
                gActual = "";
                
                novedad = _repoNovedad.GetAllNovedad();
            }
            else
            {
                gActual = g;
                novedad = _repoNovedad.GetNovedadNombre(g);
            }
        }
    }
}
