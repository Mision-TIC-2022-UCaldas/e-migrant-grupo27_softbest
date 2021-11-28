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
    public class AddMigrantesModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        private readonly IRepositorioMigrantes _repoMigrante;
        public Necesidad necesidad {get; set;}
        public IEnumerable<Migrante> migrantes {get; set;}
        public AddMigrantesModel(IRepositorioNecesidades repoNecesidad, IRepositorioMigrantes repoMigrante)
        {
            _repoNecesidad = repoNecesidad;
            _repoMigrante = repoMigrante;
        }
        public void OnGet(int Id)
        {
            necesidad = _repoNecesidad.GetNecesidad(Id);
            migrantes = _repoMigrante.GetAllMigrante();
        }
        public IActionResult OnPost(int IdNecesidad, int IdMigrante)
        {
            _repoNecesidad.AsignarMigrante(IdNecesidad, IdMigrante);
            return RedirectToPage("Details", new{Id = IdNecesidad});
        }
    }
}
