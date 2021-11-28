using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Necesidades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        public IEnumerable <Necesidad> necesidad {get; set;}
        public string gActual{get; set;}
        public IndexModel(IRepositorioNecesidades repoNecesidad)
        {
            _repoNecesidad = repoNecesidad;
        }
        public void OnGet(string g)
        {
            if (string.IsNullOrEmpty(g))
            {
                gActual = "";
                
                necesidad = _repoNecesidad.GetAllNecesidades();
            }
            else
            {
                gActual = g;
                necesidad = _repoNecesidad.GetNecesidadNombre(g);
            }
        }
    }
}
