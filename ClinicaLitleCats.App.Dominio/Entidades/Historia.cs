using System;
using System.Collections.Generic;

namespace ClinicaLitleCats.App.Dominio
{

    public class Historia
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Tratamientos> Tratamiento { get; set; }

    }

}