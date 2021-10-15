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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        public  PropietarioEncargado Propietario{get;set;}
        public DetailsModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new ClinicaLitleCats.App.Persistencia.AppContext());
       }
       public IActionResult OnGet(int propietarioEncargadoId)
       {
           Propietario=repositorioPropietarios.GetPropietario(propietarioEncargadoId);
           if (Propietario==null)
           {
               return RedirectToPage("./NotFound");               
           }
           else
           {
               return Page();
           }
       }
        public void OnGet()
        {
        }
    }
}
