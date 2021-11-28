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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNovedades _repoNovedad;
        public Novedad novedad {get; set;}
        public DetailsModel(IRepositorioNovedades repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }
        public IActionResult OnGet(int id)
        {
            novedad = _repoNovedad.GetNovedad(id);
            if (novedad == null)
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
