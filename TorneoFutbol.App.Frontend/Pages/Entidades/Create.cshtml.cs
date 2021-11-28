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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEntidades _repoEntidad;
        public Entidad entidad {get; set;}

        public CreateModel(IRepositorioEntidades repoEntidad)
        {
            _repoEntidad = repoEntidad;
        }
        public void OnGet()
        {
            entidad = new Entidad();
        }

        public IActionResult OnPost(Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                _repoEntidad.AddEntidades(entidad);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
