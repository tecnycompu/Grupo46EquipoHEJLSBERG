using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaLitleCats.App.Dominio;
using ClinicaLitleCats.App.Persistencia;
using Microsoft.AspNetCore.Authorization;



namespace ClinicaLitleCats.App.Frontend.Pages
{
   
    public class ListModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        public IEnumerable<PropietarioEncargado> propietarioEncargados{get;set;}
        public ListModel()
        {
            this.repositorioPropietarios=new RepositorioPropietario(new ClinicaLitleCats.App.Persistencia.AppContext());

        }
        public void OnGet(string filtroBusqueda)
        {
            propietarioEncargados=repositorioPropietarios.GetAllPropietarios();

        }
        
        
    }
}
