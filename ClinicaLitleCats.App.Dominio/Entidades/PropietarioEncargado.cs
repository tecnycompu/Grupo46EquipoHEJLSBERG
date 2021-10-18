using System;
using System.Collections.Generic;
namespace ClinicaLitleCats.App.Dominio
{

    public class PropietarioEncargado : Persona
    {
        public string Ocupacion { get; set; }
        public string Nexo { get; set; }
        public string Ciudad { get; set; }
        public List<PacienteCat> PacientesCats { get; set; }


    }
}