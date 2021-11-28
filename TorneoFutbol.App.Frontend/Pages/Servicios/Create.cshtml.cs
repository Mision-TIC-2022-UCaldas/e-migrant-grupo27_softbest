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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioServicios _repoServicio;
        public Servicio servicio {get; set;}

        public CreateModel(IRepositorioServicios repoServicio)
        {
            _repoServicio = repoServicio;
        }
        public void OnGet()
        {
            servicio = new Servicio();
        }

        public IActionResult OnPost(Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                _repoServicio.AddServicios(servicio);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
