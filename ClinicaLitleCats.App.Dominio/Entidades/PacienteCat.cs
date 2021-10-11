using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class PacienteCat
    {
        public int Id {get;set;}
        public string Alias { get; set; }
        public string Raza { get; set; }
        public string Edad { get; set; }
        public Genero Genero {get; set; }
        public string Color { get; set; }
        public string Estado { get; set; }
        public PropietarioEncargado PropietarioEncargado{get;set;}

        public AuxiliarVeterinario AuxiliarVeterinario {get;set;}

        public MedicoVeterinario MedicoVeterinario{get;set;}
        public Historia Historia{get;set;}
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }



    }

}