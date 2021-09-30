using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class Historia
    {
        public int id {get;set;}
        public Tratamientos Tratamientos {get;set;}
        public string Diagnostico{get;set;}
        public DateTime FechaRegistro{get;set;}

    }

}