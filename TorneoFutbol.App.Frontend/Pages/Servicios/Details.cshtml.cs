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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioServicios _repoServicio;
        public Servicio servicio {get; set;}
        public DetailsModel(IRepositorioServicios repoServicio)
        {
            _repoServicio = repoServicio;
        }
        public IActionResult OnGet(int Id)
        {
            servicio = _repoServicio.GetServicios(Id);
            if (servicio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
