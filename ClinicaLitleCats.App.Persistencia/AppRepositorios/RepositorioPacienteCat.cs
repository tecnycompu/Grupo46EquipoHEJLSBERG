using System.Collections.Generic;
using ClinicaLitleCats.App.Dominio;
using System.Linq;


namespace ClinicaLitleCats.App.Persistencia
{
    public class RepositorioPacienteCat : IRepositorioPacienteCat
    {
        // referencia al contexto de PacienteCat.
        private readonly AppContext _appContext;

        public RepositorioPacienteCat(AppContext appContext)
        {
            _appContext = appContext;

        }

        PacienteCat IRepositorioPacienteCat.AddPacienteCat(PacienteCat pacienteCat)
        {
            var pacienteCatAdicionado = _appContext.PacienteCats.Add(pacienteCat);
            _appContext.SaveChanges();
            return pacienteCatAdicionado.Entity;
        }

        void IRepositorioPacienteCat.DeletePacienteCat(int Id)
        {
            var pacienteCatEncontrado = _appContext.PacienteCats.FirstOrDefault(p => p.Id == Id);
            if (pacienteCatEncontrado == null)
                return;

            _appContext.PacienteCats.Remove(pacienteCatEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<PacienteCat> IRepositorioPacienteCat.GetAllPacientesCats()
        {
            return _appContext.PacienteCats;

        }

        PacienteCat IRepositorioPacienteCat.GetPacienteCat(int Id)
        {
            return _appContext.PacienteCats.FirstOrDefault(p => p.Id == Id);

        }

        PacienteCat IRepositorioPacienteCat.UpadatePacienteCat(PacienteCat pacienteCat)
        {
            var pacienteCatEncontrado = _appContext.PacienteCats.FirstOrDefault(p => p.Id == pacienteCat.Id);
            if(pacienteCatEncontrado!=null)
            {
                pacienteCatEncontrado.Estado=pacienteCat.Estado;

                _appContext.SaveChanges();

            }
            return pacienteCatEncontrado;           

        }
    }


}
