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
    public class EditModel : PageModel
    {
        private readonly IRepositorioNovedades _repoNovedad;
        public Novedad novedad {get; set;}
        public EditModel(IRepositorioNovedades repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }
        public IActionResult OnGet(int Id)
        {
            novedad = _repoNovedad.GetNovedad(Id);
            if (novedad == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Novedad novedad)
        {
            _repoNovedad.UpdateNovedad(novedad);
            return RedirectToPage("Index");
        }
    }
}
