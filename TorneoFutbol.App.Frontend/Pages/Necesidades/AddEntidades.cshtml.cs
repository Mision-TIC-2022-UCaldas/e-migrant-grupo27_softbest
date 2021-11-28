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
    public class AddEntidadesModel : PageModel
    {
        private readonly IRepositorioNecesidades _repoNecesidad;
        private readonly IRepositorioEntidades _repoEntidad;
        public Necesidad necesidad {get; set;}
        public IEnumerable<Entidad> entidades {get; set;}
        public AddEntidadesModel(IRepositorioNecesidades repoNecesidad, IRepositorioEntidades repoEntidad)
        {
            _repoNecesidad = repoNecesidad;
            _repoEntidad = repoEntidad;
        }
        public void OnGet(int Id)
        {
            necesidad = _repoNecesidad.GetNecesidad(Id);
            entidades = _repoEntidad.GetAllEntidades();
        }
        public IActionResult OnPost(int IdNecesidad, int IdEntidad)
        {
            _repoNecesidad.AsignarEntidad(IdNecesidad, IdEntidad);
            return RedirectToPage("Details", new{Id = IdNecesidad});
        }
    }
}
