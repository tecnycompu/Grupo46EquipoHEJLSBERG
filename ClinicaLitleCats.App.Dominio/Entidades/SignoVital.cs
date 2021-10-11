using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class SignoVital
    {
        public int Id {get;set;}
        public DateTime FechaHora { get; set; }
        public float Valor {get;set;}
        public Signo Signo { get; set; }


    }

}