using System;
using ClinicaLitleCats.App.Dominio;
using ClinicaLitleCats.App.Persistencia;
using System.Collections.Generic; //PARA EL MANEJO DE LISTAS


namespace ClinicaLitleCats.App.Consola
{
    class Program
    {
        private static IRepositorioPacienteCat _repoPacienteCat = new RepositorioPacienteCat(new Persistencia.AppContext());
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema!");
            AddPropietario();

            //AddPacienteCat();
            //BuscarPacienteCat(1);
            //ListarPacientesCorazon();

        }

        private static void AddPropietario()
        {
            var propietario = new PropietarioEncargado()
            {
                DocumentoIdentidad = "10145214455",
                Nombre = "Cesar",
                Apellido = "Palacios",
                Celular = "3145658956",
                Email = "user3@latin.com",
                Direccion = "Centro cali",
                Ocupacion= "diseñador",
                Nexo = "Propietario",
                Ciudad = "Cali valle"
            };
            _repoPropietario.AddPropietario(propietario);

        }


         private static void AddPacienteCat()
        {
            var pacienteCat = new PacienteCat
             {
            Estado = "Sano",
            Alias = "Minino",
            Raza = "Angora",
            Edad = "2 años",
            Color = "Negro",
            Genero = Genero.macho
        };

        _repoPacienteCat.AddPacienteCat(pacienteCat);
    }
    private static void BuscarPacienteCat(int IdPacienteCat)
    {

        var pacienteCat = _repoPacienteCat.GetPacienteCat(IdPacienteCat);
        Console.WriteLine(pacienteCat.Alias + " " + pacienteCat.Raza);

    }

}
}
