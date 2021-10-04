using System.Collections.Generic;
using ClinicaLitleCats.App.Dominio;

namespace ClinicaLitleCats.App.Persistencia
{
    public interface IRepositorioPacienteCat
    {
        IEnumerable<PacienteCat> GetAllPacientesCats();
        PacienteCat AddPacienteCat(PacienteCat pacienteCat);
        PacienteCat UpadatePacienteCat(PacienteCat pacienteCat);
        void DeletePacienteCat(int Id);
        PacienteCat GetPacienteCat(int Id);

    }



}


