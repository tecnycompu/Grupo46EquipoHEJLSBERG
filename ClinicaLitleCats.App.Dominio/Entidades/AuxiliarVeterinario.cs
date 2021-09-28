using System;
//using System.ComponentModel.DataAnnotations;
//using System.Data.Entity.Core;
//using System.Data.Entity.Core.Objects.ObjectQuery;




namespace ClinicaLitleCats.App.Dominio
{

//[Keyless]

    public class AuxiliarVeterinario
    {
        //Primary Key (IdAuxiliar);
        public int IdAuxiliar  {get;set;}
        public string TarjetaProfesional{get;set;}

        public int HorasLaborales{get;set;}

    }


}