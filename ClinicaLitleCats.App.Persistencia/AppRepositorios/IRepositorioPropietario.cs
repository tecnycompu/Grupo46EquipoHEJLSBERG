using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ClinicaLitleCats.App.Dominio;

namespace ClinicaLitleCats.App.Persistencia
{
    public interface IRepositorioPropietario
    {

        // FIRMA DE METODOS
        IEnumerable<PropietarioEncargado> GetAllPropietarios();
        PropietarioEncargado AddPropietario(PropietarioEncargado propietario);
        PropietarioEncargado UpadatePropietario(PropietarioEncargado Propietario);
        void DeletePropietario(int idPropietario);
        PropietarioEncargado GetPropietario(int idPropietario);
    }




}