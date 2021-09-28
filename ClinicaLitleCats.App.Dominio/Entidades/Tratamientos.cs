using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class Tratamientos
    {
        public int IdTratamientos { get; set; }
        public DateTime FechaHoraTratamiento { get; set; }
        public string Descripcion { get; set; }
        public int IdHistoria { get; set; }

    }

}
