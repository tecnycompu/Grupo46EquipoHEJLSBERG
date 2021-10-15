using Microsoft.EntityFrameworkCore;
using ClinicaLitleCats.App.Dominio;

namespace ClinicaLitleCats.App.Persistencia
{
public class AppContext : DbContext
{

    public DbSet<Persona> Personas{get;set;}
    public DbSet<AuxiliarVeterinario> AuxiliaresVeterinarios{get;set;}
    public DbSet<Historia> Historias{get;set;}
    public DbSet<MedicoVeterinario> MedicosVeterinarios{get;set;}
    public DbSet<PacienteCat> PacienteCats{get;set;}
    public DbSet<PropietarioEncargado> PropietariosEncargados{get;set;}
    public DbSet<SignoVital> SignosVitales{get;set;}
    public DbSet<Tratamientos> Tratamiento{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
          optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaLitleCatsData");
        }
    }


// no olvidar buscar asure y crear una nueva conexion
// (localdb)\MSSQLLocalDB
//al igual que en sql sever management studio
// si salen errores es mejor borrar toda la base de datos
// y aplicar nuevamente solo el update

}

}