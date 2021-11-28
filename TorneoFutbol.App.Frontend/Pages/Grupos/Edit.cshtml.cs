using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Grupos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioGrupos _repoGrupo;
        public Grupo grupo {get; set;}
        public EditModel(IRepositorioGrupos repoGrupo)
        {
            _repoGrupo = repoGrupo;
        }
        public IActionResult OnGet(int Id)
        {
            grupo = _repoGrupo.GetGrupo(Id);
            if (grupo == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Grupo grupo)
        {
            _repoGrupo.UpdateGrupo(grupo);
            return RedirectToPage("Index");
        }
    }
}