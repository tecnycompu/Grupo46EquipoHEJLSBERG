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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        [BindProperty]
        public  PropietarioEncargado Propietario{get;set;}
        public DeleteModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new ClinicaLitleCats.App.Persistencia.AppContext());
        }
    
        public IActionResult OnGet(int? propietarioId) 
        {
            if (propietarioId.HasValue)
            {
                Propietario=repositorioPropietarios.GetPropietario(propietarioId.Value);
            }
            
            if (Propietario==null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return Page();
            }
        }



        public IActionResult OnPost() 
        
        {
                if (!ModelState.IsValid)
                {
                    return Page();
                } 
                
                if (Propietario.Id > 0)
                {
                    repositorioPropietarios.DeletePropietario(Propietario.Id);        
                }
                else
                {
                    repositorioPropietarios.AddPropietario(Propietario);                 
                }
                return Page();
        } 
        
    }
}
