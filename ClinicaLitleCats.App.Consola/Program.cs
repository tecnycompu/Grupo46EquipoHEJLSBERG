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
            //AddPacienteCat();
            BuscarPacienteCat(1);

        }
        private static void AddPacienteCat()
        {
            var pacienteCat = new PacienteCat{
                Estado="Sano",
                Alias="Minino",
                Raza="Angora",
                Edad="2 años",
                Color="Negro",
                               

            };

            _repoPacienteCat.AddPacienteCat(pacienteCat);
        }
        private static void BuscarPacienteCat(int IdPacienteCat)
        {

            var pacienteCat=_repoPacienteCat.GetPacienteCat(IdPacienteCat);
            Console.WriteLine(pacienteCat.Alias+" "+pacienteCat.Raza);

        }

    }
}
