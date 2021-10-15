using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaLitleCats.App.Dominio;
using ClinicaLitleCats.App.Persistencia;

namespace ClinicaLitleCats.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        [BindProperty]
        public  PropietarioEncargado Propietario{get;set;}
        public EditModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new ClinicaLitleCats.App.Persistencia.AppContext());
        }
    
        public IActionResult OnGet(int propietarioEncargadoId)
        {
            if (propietarioEncargadoId.HasValue)
            {
                Propietario=repositorioPropietarios.GetPropietario(propietarioEncargadoId.value);
            }
            else
            {
                    Propietario=new PropietarioEncargado();
            }
            if (Propietario==null)
            {
                return RedirectToPage("./Notfound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                if (Propietario.Id>0)
                {
                    Propietario=repositorioPropietarios.UpdatePropietario(Propietario);
                }
                else
                {
                    repositorioPropietarios.AddPropietario(Propietario);
                }
                return Page();
        }
        
    }
}
