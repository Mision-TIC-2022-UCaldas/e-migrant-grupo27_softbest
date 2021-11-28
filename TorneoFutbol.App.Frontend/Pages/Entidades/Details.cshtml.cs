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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEntidades _repoEntidad;
        public Entidad entidad {get; set;}
        public DetailsModel(IRepositorioEntidades repoEntidad)
        {
            _repoEntidad = repoEntidad;
        }
        public IActionResult OnGet(int Id)
        {
            entidad = _repoEntidad.GetEntidades(Id);
            if (entidad == null)
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
