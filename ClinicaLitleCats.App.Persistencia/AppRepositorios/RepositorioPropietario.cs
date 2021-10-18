using System;
using System.Collections;
using System.Collections.Generic;
using ClinicaLitleCats.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ClinicaLitleCats.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        private readonly AppContext _appContext;
        public RepositorioPropietario(AppContext appContext) 
        {
            _appContext=appContext;
        }
                
        //PropietarioEncargado IRepositorioPropietario.AddPropietario(PropietarioEncargado propietario)
        public PropietarioEncargado AddPropietario(PropietarioEncargado propietario)
        {
            var propietarioAdicionado =_appContext.PropietariosEncargados.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;      
        }
        
        //PropietarioEncargado IRepositorioPropietario.UpdatePropietario(PropietarioEncargado propietario)//Propietario
        public PropietarioEncargado UpdatePropietario(PropietarioEncargado propietario)
        {
            var propietarioEncontrado=_appContext.PropietariosEncargados.FirstOrDefault(p => p.Id==  propietario.Id); //Propietario.Id
            if(propietarioEncontrado!=null)
                {
                    propietarioEncontrado.DocumentoIdentidad=propietario.DocumentoIdentidad;
                    propietarioEncontrado.Nombre=propietario.Nombre;
                    propietarioEncontrado.Apellido=propietario.Apellido;
                    propietarioEncontrado.Celular=propietario.Celular;
                    propietarioEncontrado.Email=propietario.Email;
                    propietarioEncontrado.Direccion=propietario.Direccion;

                    _appContext.SaveChanges();

                }
                return propietarioEncontrado;



        }
        //void IRepositorioPropietario.DeletePropietario(int idPropietario)
        public void DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado =_appContext.PropietariosEncargados.FirstOrDefault(p => p.Id ==idPropietario);
            if (propietarioEncontrado==null)
                return;
            _appContext.PropietariosEncargados.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        //AGREGADO DE HOSPI EN CASA********
        public IEnumerable<PropietarioEncargado> GetAllPropietarios()
        {
            return GetAllPropietarios_();
        }        
        
        public IEnumerable<PropietarioEncargado> GetPropietariosPorFiltro(string filtro)
        {
            var PropietariosEncargados = GetAllPropietarios(); // Obtiene todos los saludos
            if (PropietariosEncargados != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    PropietariosEncargados = PropietariosEncargados.Where(s => s.Nombre.Contains(filtro));
                }

            }
            return PropietariosEncargados;

        }
        public IEnumerable<PropietarioEncargado> GetAllPropietarios_()
        {
            return _appContext.PropietariosEncargados;
        }
        //*********************


        PropietarioEncargado IRepositorioPropietario.GetPropietario(int idPropietario)
        {
            return _appContext.PropietariosEncargados.FirstOrDefault(p => p.Id ==idPropietario);           
        }

        IEnumerable<PropietarioEncargado> IRepositorioPropietario.GetAllPropietarios()
        {
             return _appContext.PropietariosEncargados;
            //return _appContext.PropietariosEncargados.include(c => c.ClientesCats);



        }




    }


}