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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        public Necesidad necesidad {get; set;}
        public CreateModel(IRepositorioNecesidades repoNecesidad)
        {
            _repoNecesidad = repoNecesidad;
        }
        public void OnGet()
        {
            necesidad = new Necesidad();
        }

        public IActionResult OnPost(Necesidad necesidad)
        {
            if (ModelState.IsValid)
            {
                _repoNecesidad.AddNecesidades(necesidad);
                return RedirectToPage("Index");
            }

            else
            {
                return Page();
            }
            
        }
    }
}
