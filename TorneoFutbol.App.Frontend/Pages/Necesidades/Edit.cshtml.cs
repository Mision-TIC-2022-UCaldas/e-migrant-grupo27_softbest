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
    public class EditModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        public Necesidad necesidad {get; set;}
        public EditModel(IRepositorioNecesidades repoNecesidad)
        {
            _repoNecesidad = repoNecesidad;
        }
        public IActionResult OnGet(int Id)
        {
            necesidad = _repoNecesidad.GetNecesidad(Id);
            if (necesidad == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Necesidad necesidad)
        {
            _repoNecesidad.UpdateNecesidad(necesidad);
            return RedirectToPage("Index");
        }
    }
}
