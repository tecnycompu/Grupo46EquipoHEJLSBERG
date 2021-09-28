using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class SignoVital
    {
        public int IdSignoVital { get; set; }
        public DateTime FechaHora { get; set; }
        public Signo Signo { get; set; }
        public long  Valor { get; set; }


    }

}