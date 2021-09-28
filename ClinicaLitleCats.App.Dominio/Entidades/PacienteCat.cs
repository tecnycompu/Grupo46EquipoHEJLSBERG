using System;
namespace ClinicaLitleCats.App.Dominio
{

    public class PacienteCat
    {
        public int IdCat { get; set; }
        public string Alias { get; set; }
        public string Raza { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string Color { get; set; }
        public Byte[] Foto { get; set; }
        public string Estado { get; set; }
        public int IdPropietario { get; set; }
       
    }

}