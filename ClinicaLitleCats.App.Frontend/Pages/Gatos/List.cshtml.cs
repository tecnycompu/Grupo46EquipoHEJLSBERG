using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaLitleCats.App.Frontend.Pages
{
    /*public class ListModel : PageModel
    {
        private readonly IRepositorioPacienteCat repositorioPacienteCats;
        private readonly IRepositorioPropietario repositorioPropietarios;

        public IEnumerable<PropietarioEncargado> propietario{get;set;}
        
        public ListModel()
        {

            this.repositorioPacienteCats = new RepositorioPacienteCat (new ClinicaLitleCats.App.Persistencia.AppContext());
            this.repositorioPropietarios= new RepositorioPropietario(new ClinicaLitleCats.App.Persistencia.AppContext());

        }
        public void OnGet()
        {

            propietarioEncargados= repositorioPropietarios.GetAllPropietarios();

        }
        public void OnPost(int idPacienteCat)
        {
            repositorioPacienteCats.DeletePacienteCat(idPacienteCat);
            viewData["Respuesta"]=Alerts.ShowAlert(Alert.Danger,"<span>El Paciente se va a borrar</>");
            propietarioEncargados=repositorioPropietarios.GetAllPropietarios();
        } 
    }*/
}
