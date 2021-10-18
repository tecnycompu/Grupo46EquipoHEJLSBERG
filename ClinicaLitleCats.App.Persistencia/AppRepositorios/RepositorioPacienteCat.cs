using System.Collections;
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

        void IRepositorioPacienteCat.DeletePacienteCat(int idPacienteCat)
        {
            var pacienteCatEncontrado = _appContext.PacienteCats.FirstOrDefault(p => p.Id == idPacienteCat);
            if (pacienteCatEncontrado == null)
                return;

            _appContext.PacienteCats.Remove(pacienteCatEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<PacienteCat> IRepositorioPacienteCat.GetAllPacientesCats()
        {
            return _appContext.PacienteCats;

        }

        PacienteCat IRepositorioPacienteCat.GetPacienteCat(int idPacienteCat)
        {
            return _appContext.PacienteCats.FirstOrDefault(p => p.Id == idPacienteCat);

        }

        PacienteCat IRepositorioPacienteCat.UpadatePacienteCat(PacienteCat pacienteCat)
        {
            var pacienteCatEncontrado = _appContext.PacienteCats.FirstOrDefault(p => p.Id == pacienteCat.Id);
            if(pacienteCatEncontrado!=null)
            {
                pacienteCatEncontrado.Alias=pacienteCat.Alias;
                pacienteCatEncontrado.Raza=pacienteCat.Raza;
                pacienteCatEncontrado.Edad=pacienteCat.Edad;
                pacienteCatEncontrado.Genero=pacienteCat.Genero;
                pacienteCatEncontrado.Color=pacienteCat.Color;                
                pacienteCatEncontrado.Estado=pacienteCat.Estado;
                pacienteCatEncontrado.PropietarioEncargado=pacienteCat.PropietarioEncargado;
                pacienteCatEncontrado.MedicoVeterinario=pacienteCat.MedicoVeterinario;
                



                _appContext.SaveChanges();

            }
            return pacienteCatEncontrado;           

        }
        
        public MedicoVeterinario AsignarMedicoVeterinario(int idPacienteCat, int idMedico)
        {
             var pacienteCatEncontrado=_appContext.PacienteCats.FirstOrDefault(p => p.Id == idPacienteCat);
            if (pacienteCatEncontrado != null)
            {
                var medicoEncontrado = _appContext.MedicosVeterinarios.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteCatEncontrado.MedicoVeterinario = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;   
        }
        public IEnumerable<PacienteCat> GetPacienteCatsCorazon()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PacienteCat> GetPacienteCatsMacho()
        {
            throw new System.NotImplementedException();
        }

    }


}
