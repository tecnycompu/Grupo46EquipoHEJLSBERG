using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ClinicaLitleCats.App.Dominio;

namespace ClinicaLitleCats.App.Persistencia
{
    public interface IRepositorioPacienteCat
    {
        IEnumerable<PacienteCat> GetAllPacientesCats();
        PacienteCat AddPacienteCat(PacienteCat pacienteCat);
        PacienteCat UpadatePacienteCat(PacienteCat pacienteCat);
        void DeletePacienteCat(int idPacienteCat);
        PacienteCat GetPacienteCat(int idPacienteCat);
        MedicoVeterinario AsignarMedicoVeterinario(int idPacienteCat, int idMedico);
        IEnumerable<PacienteCat> GetPacienteCatsMacho();
        IEnumerable<PacienteCat> GetPacienteCatsCorazon();


    }



}


