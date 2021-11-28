using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Servicios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioServicios _repoServicio;
        public IEnumerable <Servicio> servicio {get; set;}
        public string gActual{get; set;}
        public IndexModel(IRepositorioServicios repoServicio)
        {
            _repoServicio = repoServicio;
        }
        public void OnGet(string g)
        {
            if (string.IsNullOrEmpty(g))
            {
                gActual = "";
                
                servicio = _repoServicio.GetAllServicios();
            }
            else
            {
                gActual = g;
                servicio = _repoServicio.GetServicioNombre(g);
            }
        }
    }
}
