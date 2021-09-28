using Microsoft.EntityFrameworkCore;
using ClinicaLitleCats.App.Dominio;

namespace ClinicaLitleCats.App.Persistencia
{
public class AppContext : DbContext
{

    public DbSet<Persona> Personas{get;set;}
    public DbSet<AuxiliarVeterinario> Auxiliares{get;set;}
    public DbSet<Historia> Historias{get;set;}
    public DbSet<MedicoVeterinario> Medicos{get;set;}
    public DbSet<PacienteCat> PacienteCats{get;set;}
    public DbSet<PropietarioEncargado> PropietarioEncargados{get;set;}
    //public DbSet<Signo> Signos{get;set;}
    public DbSet<SignoVital> SignosVitales{get;set;}
    public DbSet<Tratamientos> Tratamiento{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
          optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaLitleCatsData");
        }
    }



}

}