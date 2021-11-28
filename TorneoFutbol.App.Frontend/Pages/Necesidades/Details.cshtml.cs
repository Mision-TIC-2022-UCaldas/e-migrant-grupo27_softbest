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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        public Necesidad necesidad {get; set;}
        public DetailsModel(IRepositorioNecesidades repoNecesidad)
        {
            _repoNecesidad = repoNecesidad;
        }
        public IActionResult OnGet(int id)
        {
            necesidad = _repoNecesidad.GetNecesidad(id);
            if (necesidad == null)
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
