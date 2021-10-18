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
    
        public IActionResult OnGet(int? propietarioId) 
        {
            if (propietarioId.HasValue)
            {
                Propietario=repositorioPropietarios.GetPropietario(propietarioId.Value);
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
            {
                return Page();
            }
        }



        public IActionResult OnPost() //PropietarioEncargado Propietario
        
        {
                if (!ModelState.IsValid)
                {
                    return Page();
                } 

                Console.WriteLine("PropietarioId: "+Propietario.Id);

                //ojo no esta validando el usuario encontrado
                if (Propietario.Id > 0)
                {
                    Propietario=repositorioPropietarios.UpdatePropietario(Propietario);
                    Console.WriteLine("ingreso por update");
                }
                else
                {
                    repositorioPropietarios.AddPropietario(Propietario);
                    Console.WriteLine("ingreso por crear");
                }
                return Page();
        } 
        
    }
}
