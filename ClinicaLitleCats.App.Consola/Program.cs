using System;
using ClinicaLitleCats.App.Dominio;
using ClinicaLitleCats.App.Persistencia;


namespace ClinicaLitleCats.App.Consola
{
    class Program
    {
        private static IRepositorioPacienteCat _repoPacienteCat=new RepositorioPacienteCat(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema!");
            AddPacienteCat();

        }
        private static void AddPacienteCat()
        {
            var pacienteCat = new PacienteCat{
                Estado="Sano",

            };

            _repoPacienteCat.AddPacienteCat(pacienteCat);
        }
    }
}
